using Microsoft.EntityFrameworkCore;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class RepositorioMedicamentos
    {
        private static RepositorioMedicamentos instancia;

        private readonly Parcial1Context context;
        public RepositorioMedicamentos()
        {
            context = new Parcial1Context();
        }
        public static RepositorioMedicamentos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioMedicamentos();
                }
                return instancia;
            }
        }
        #region public methods
        public List<MedicamentoDTO> Obtener()
        {
            return context.Medicamentos.Select(x => new MedicamentoDTO
            {
                NombreComercial = x.NombreComercial,
                EsVentaLibre = x.EsVentaLibre,
                PrecioVenta = x.PrecioVenta,
                Stock = x.Stock,
                StockMinimo = x.StockMinimo,
                NombreMonodroga = x.IdMonodrograNavigation.Nombre
            }).ToList();
        }
        public bool Agregar(Medicamento medicamento)
        {
            
            
            return context.SaveChanges() > 0;

        }
        public bool Modificar(MedicamentoDTO medicamento)
        {
            var med = context.Medicamentos.Include(x => x.IdDrogueria).FirstOrDefault(c => c.NombreComercial == medicamento.NombreComercial);
            //med = medicamento;
            med.IdDrogueria.Clear(); // Limpio para asignar el nuevo

            foreach (var drogueria in med.IdDrogueria)
            {
                context.Entry(drogueria).State = EntityState.Unchanged;
                med.IdDrogueria.Add(drogueria);
            }

            return context.SaveChanges() > 0;// Guarda los cambios en la base de datos
        }
        public bool Eliminar(Medicamento medicamento)
        {
            context.Medicamentos.Remove(medicamento);

            return context.SaveChanges() > 0; // Guardar cambios
        }
        #endregion
    }
}
