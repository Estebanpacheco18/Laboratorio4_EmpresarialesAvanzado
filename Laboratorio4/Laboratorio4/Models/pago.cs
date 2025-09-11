using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class pago
{
    public int PagoID { get; set; }

    public int? OrdenID { get; set; }

    public decimal Monto { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? MetodoPago { get; set; }

    public virtual ordene? Orden { get; set; }
}
