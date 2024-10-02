using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepositorioDroguerias
    {
        private static RepositorioDroguerias instancia;

        private readonly Parcial1Context context;

        public RepositorioDroguerias()
        {
            context = new Parcial1Context();
        }
        public static RepositorioDroguerias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioDroguerias();
                }
                return instancia;
            }
        }
        #region public methods
        public List<DrogueriaDTO> Obtener() => context.Droguerias.Select(x => new DrogueriaDTO
        {
            Cuit = x.Cuit,
            RazonSocial = x.RazonSocial,
            Direccion = x.Direccion,
            Email = x.Email
        }).ToList();

        public bool Agregar(Drogueria nuevaDrogueria)
        {
            context.Droguerias.Add(nuevaDrogueria);
            return context.SaveChanges() > 0; // Si el valor devuelto es diferente a 0 se agrego el elemento

        }
        public bool Modificar(Drogueria drogueriaModificada)
        {
            context.Droguerias.Update(drogueriaModificada);
            return context.SaveChanges() > 0;// Guarda los cambios en la base de datos
        }

        public bool Eliminar(Drogueria drogueria)
        {

            context.Droguerias.Remove(drogueria);
            return context.SaveChanges() > 0;
        }
        #endregion
    }
}
