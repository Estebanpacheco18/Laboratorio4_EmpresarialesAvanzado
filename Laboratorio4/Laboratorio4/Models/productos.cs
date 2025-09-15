using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class productos
{
    public int ProductoID { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? CategoriaID { get; set; }

    public virtual categorias? Categoria { get; set; }

    public virtual ICollection<detallesorden> detallesordens { get; set; } = new List<detallesorden>();
}
