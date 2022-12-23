using System;
using System.Collections.Generic;

namespace IntroASP.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Color { get; set; }

    public decimal Precio { get; set; }
}
