using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControladoraMonodrogas
    {
        private ControladoraMonodrogas() { }
        private static ControladoraMonodrogas instancia;
        public static ControladoraMonodrogas Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraMonodrogas();
                return instancia;
            }
        }
        public List<MonodrogaDTO> RecuperarMonodrogas()
        {
            try
            {
                return RepositorioMonodrogas.Instancia.Obtener();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string AgregarMonodroga(Monodroga monodroga)
        {
            try
            {
                var monodrogaEncontrada = RepositorioMonodrogas.Instancia.Obtener().FirstOrDefault(x => x.Nombre.ToLower() == monodroga.Nombre.ToLower());
                if (monodrogaEncontrada == null)
                {
                    if (RepositorioMonodrogas.Instancia.Agregar(monodroga))
                    {
                        return $"La monodroga: {monodroga.Nombre} se agregó correctamente";
                    }
                    else return $"La monodroga: {monodroga.Nombre} no se ha podido agregar";
                }
                else
                {
                    return $"La monodroga {monodroga.Nombre} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }
        public string ModificarMonodroga(Monodroga monodroga)
        {
            try
            {
                //var proveedorEncontrado = RepositorioMonodrogas.Instancia.Obtener().FirstOrDefault(x => x == monodroga.Nombre);
                //if (proveedorEncontrado != null)
                //{
                //    var ok = RepositorioMonodrogas.Instancia.Modificar(monodroga);
                //    if (ok)
                //    {
                //        return $"La monodroga: {monodroga.Nombre} se modifico correctamentee";
                //    }
                //    else return $"La monodroga: {monodroga.Nombre} no se ha podido modificar";
                //}
                //else
                //{
                //    return $"La monodroga: {monodroga.Nombre} no existe.";
                //}
                return "";
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }
        public string EliminarMonodroga(Monodroga monodroga)
        {
            try
            {
                //var proveedorEncontrado = RepositorioMonodrogas.Instancia.Obtener().FirstOrDefault(x => x == monodroga.Nombre);
                //if (proveedorEncontrado != null)
                //{
                //    var ok = RepositorioMonodrogas.Instancia.Eliminar(monodroga);
                //    if (ok)
                //    {
                //        return $"La monodroga: {monodroga.Nombre} se eliminó correctamentee";
                //    }
                //    else return $"La monodroga: {monodroga.Nombre} no se ha podido eliminar";
                //}
                //else
                //{
                //    return $"La monodroga: {monodroga.Nombre} no existe.";
                //}
                return "";

            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }
    }
}
