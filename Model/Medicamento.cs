using System;
using System.Collections.Generic;

namespace Model;

public partial class Medicamento
{
    public int Id { get; set; }

    public string NombreComercial { get; set; } = null!;

    public bool EsVentaLibre { get; set; }

    public decimal PrecioVenta { get; set; }

    public int Stock { get; set; }

    public int StockMinimo { get; set; }

    public int IdMonodrogra { get; set; }

    public virtual Monodroga IdMonodrograNavigation { get; set; } = null!;

    public virtual ICollection<Drogueria> IdDrogueria { get; set; } = new List<Drogueria>();
}
