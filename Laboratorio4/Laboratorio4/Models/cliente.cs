using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class cliente
{
    public int ClienteID { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<ordene> ordenes { get; set; } = new List<ordene>();
}
