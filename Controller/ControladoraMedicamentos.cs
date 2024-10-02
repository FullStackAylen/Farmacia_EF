using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControladoraMedicamentos
    {
        private ControladoraMedicamentos() { }

        private static ControladoraMedicamentos instancia;
        public static ControladoraMedicamentos Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraMedicamentos();
                return instancia;
            }
        }
        public List<MedicamentoDTO> RecuperarMedicamentos()
        {
            try
            {
                return RepositorioMedicamentos.Instancia.Obtener();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string AgregarMedicamento(MedicamentoDTO medicamento)
        {
            try
            {
                var med = RepositorioMedicamentos.Instancia.Obtener().FirstOrDefault(x => x.NombreComercial.ToLower() == medicamento.NombreComercial.ToLower());
                if (med == null)
                {
                    if (RepositorioMedicamentos.Instancia.Agregar(med))
                        return $"El medicamento: {medicamento.NombreComercial} fue agregado exitosamente";
                    else
                        return $"El medicamento: {medicamento.NombreComercial} no se ha podido agregar";
                }
                return $"El medicamento: {medicamento.NombreComercial} ya existe!";
            }
            catch (Exception)
            {

                return "Error innesperado";
            }
        }
        public string ModificarMedicamento(MedicamentoDTO medicamento)
        {
            try
            {
                if (RepositorioMedicamentos.Instancia.Modificar(medicamento))
                    return $"El medicamento: {medicamento.NombreComercial} fue editado exitosamente";
                else
                    return $"El medicamento: {medicamento.NombreComercial} no se ha podido editar";
            }
            catch (Exception)
            {

                return "Error innesperado";
            }
        }
        public string EliminarMedicamento(Medicamento medicamento)
        {
            try
            {
                //if (RepositorioMedicamentos.Instancia.Obtener().FirstOrDefault(x => x.Id == medicamento.Id) == null)
                //{
                //    if (RepositorioMedicamentos.Instancia.Eliminar(medicamento))
                //        return $"El medicamento: {medicamento.NombreComercial} fue eliminado correctamente";
                //    else
                //        return $"El medicamento: {medicamento.NombreComercial} no se ha podido eliminar";
                //}
                return $"El medicamento: {medicamento.NombreComercial} no existe";
            }
            catch (Exception)
            {
                return "Error innesperado";
            }
        }
    }
}
