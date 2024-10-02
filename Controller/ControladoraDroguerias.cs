using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControladoraDroguerias
    {
        private ControladoraDroguerias() { }
        private static ControladoraDroguerias instancia;
        public static ControladoraDroguerias Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraDroguerias();
                return instancia;
            }
        }
        public List<DrogueriaDTO> RecuperarDroguerias()
        {
            try
            {
                return RepositorioDroguerias.Instancia.Obtener();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string AgregarDrogueria(Drogueria drogueria)
        {
            try
            {
                var drogueriaEncontrada = RepositorioDroguerias.Instancia.Obtener().FirstOrDefault(x => x.RazonSocial.ToLower() == drogueria.RazonSocial.ToLower());
                if (drogueriaEncontrada == null)
                {
                    if (RepositorioDroguerias.Instancia.Agregar(drogueria))
                    {
                        return $"La drogueria con la razon social: {drogueria.RazonSocial} se agregó correctamente";
                    }
                    else return $"La drogueria con la razon social: {drogueria.RazonSocial} no se ha podido agregar";
                }
                else
                {
                    return $"La drogueria {drogueria.RazonSocial} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }
        public string ModificarDrogueria(Drogueria drogueria)
        {
            //try
            //{
            //    var proveedorEncontrado = RepositorioDroguerias.Instancia.Obtener().FirstOrDefault(x => x.Id == drogueria.Id);
            //    if (proveedorEncontrado != null)
            //    {
            //        var ok = RepositorioDroguerias.Instancia.Modificar(drogueria);
            //        if (ok)
            //        {
            //            return $"La drogueria con la razon social: {drogueria.RazonSocial} se modifico correctamentee";
            //        }
            //        else return $"La drogueria con la razon social: {drogueria.RazonSocial} no se ha podido modificar";
            //    }
            //    else
            //    {
            //        return $"La drogueria con la razon social: {drogueria.RazonSocial} no existe.";
            //    }
            //}
            //catch (Exception)
            //{
            return "Error desconocido";
            //}
        }
        public string EliminarDrogueria(Drogueria drogueria)
        {
            //try
            //{
            //    var proveedorEncontrado = RepositorioDroguerias.Instancia.Obtener().FirstOrDefault(x => x.Id == drogueria.Id);
            //    if (proveedorEncontrado != null)
            //    {
            //        var ok = RepositorioDroguerias.Instancia.Eliminar(drogueria);
            //        if (ok)
            //        {
            //            return $"La drogueria con la razon social: {drogueria.Id} se eliminó correctamentee";
            //        }
            //        else return $"La drogueria con la razon social: {drogueria.Id} no se ha podido eliminar";
            //    }
            //    else
            //    {
            //        return $"La drogueria con la razon social:  {drogueria.Id} no existe.";
            //    }
            //}
            //catch (Exception)
            //{
            return "Error desconocido";
            //}
        }
    }
}
