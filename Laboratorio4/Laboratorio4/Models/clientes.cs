using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class clientes
{
    public int ClienteID { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<ordenes> ordenes { get; set; } = new List<ordenes>();
}
