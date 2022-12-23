using System;
using System.Collections.Generic;

namespace IntroASP.Models;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaVenta { get; set; }
}
