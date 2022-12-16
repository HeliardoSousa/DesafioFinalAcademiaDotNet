using System;
using System.Collections.Generic;

namespace DesafioFinal.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<Artigo> Artigos { get; } = new List<Artigo>();
}
