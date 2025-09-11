using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class ordene
{
    public int OrdenID { get; set; }

    public int? ClienteID { get; set; }

    public DateTime? FechaOrden { get; set; }

    public decimal Total { get; set; }

    public virtual cliente? Cliente { get; set; }

    public virtual ICollection<detallesorden> detallesordens { get; set; } = new List<detallesorden>();

    public virtual ICollection<pago> pagos { get; set; } = new List<pago>();
}
