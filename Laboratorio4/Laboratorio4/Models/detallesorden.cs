using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class detallesorden
{
    public int DetalleID { get; set; }

    public int? OrdenID { get; set; }

    public int? ProductoID { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public virtual ordenes? Orden { get; set; }

    public virtual productos? Producto { get; set; }
}
