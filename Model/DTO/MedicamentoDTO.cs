using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicamentoDTO
    {
        public string NombreComercial { get; set; }

        public bool EsVentaLibre { get; set; }

        public decimal PrecioVenta { get; set; }

        public int Stock { get; set; }

        public int StockMinimo { get; set; }

        public string NombreMonodroga { get; set; }
        private List<Drogueria> droguerias;
        public ReadOnlyCollection<Drogueria> Droguerias
        {
            get => droguerias.AsReadOnly();
        }

        public MedicamentoDTO()
        {
            droguerias = new List<Drogueria>();
        }


    }
}
