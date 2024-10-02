using Microsoft.EntityFrameworkCore;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepositorioMonodrogas
    {
        private static RepositorioMonodrogas instancia;
        private readonly Parcial1Context context;
        public RepositorioMonodrogas()
        {
            context = new Parcial1Context();
        }
        public static RepositorioMonodrogas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioMonodrogas();
                }
                return instancia;
            }
        }
        #region public methods
        public List<MonodrogaDTO> Obtener()
        {
            return context.Monodrogas.FromSqlRaw("EXEC SP_RECUPERARMONODROGAS").AsEnumerable()
           .Select(m => new MonodrogaDTO { Nombre = m.Nombre })
           .ToList();
        }




        public bool Agregar(Monodroga nuevaMonodroga)
        {
            context.Monodrogas.Add(nuevaMonodroga);
            return context.SaveChanges() > 0; // Si el valor devuelto es diferente a 0 se agrego el elemento

        }
        public bool Modificar(Monodroga monodrogaModificada)
        {
            context.Monodrogas.Update(monodrogaModificada);
            return context.SaveChanges() > 0;// Guarda los cambios en la base de datos
        }

        public bool Eliminar(Monodroga monodroga)
        {
            context.Monodrogas.Remove(monodroga);
            return context.SaveChanges() > 0;
        }
        #endregion
    }
}
