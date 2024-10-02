using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class DrogueriaDTO
    {
        public long Cuit { get; set; }

        public string RazonSocial { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string? Email { get; set; }
    }
}
