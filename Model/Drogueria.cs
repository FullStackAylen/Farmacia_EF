using System;
using System.Collections.Generic;

namespace Model;

public partial class Drogueria
{
    public int Id { get; set; }

    public long Cuit { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Medicamento> IdMedicamentos { get; set; } = new List<Medicamento>();
}
