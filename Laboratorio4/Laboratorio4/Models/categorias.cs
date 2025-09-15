using System;
using System.Collections.Generic;

namespace Laboratorio4.Models;

public partial class categorias
{
    public int CategoriaID { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<productos> productos { get; set; } = new List<productos>();
}
