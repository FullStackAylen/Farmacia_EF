using System;
using System.Collections.Generic;

namespace Model;

public partial class Monodroga
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();
}
