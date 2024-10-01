using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepositorioDroguerias
    {
        private readonly Parcial1Context context;

        public RepositorioDroguerias()
        {
            context = new Parcial1Context();
        }

        public void AgregarDrogueria(Drogueria nuevaDrogueria)
        {
            
        }

        public List<Drogueria> ObtenerDroguerias()
        {
            return context.Droguerias.ToList();
        }

        public void ModificarDrogueria(Drogueria drogueriaModificada)
        {
            context.Droguerias.Update(drogueriaModificada);
            context.SaveChanges(); // Guarda los cambios en la base de datos
        }

        public void EliminarDrogueria(long cuit)
        {
            var drogueria = context.Droguerias.Find(cuit); // Busca la droguería por su CUIT
            if (drogueria != null)
            {
                context.Droguerias.Remove(drogueria);
                context.SaveChanges(); // Guarda los cambios en la base de datos
            }
        }
    }
}
