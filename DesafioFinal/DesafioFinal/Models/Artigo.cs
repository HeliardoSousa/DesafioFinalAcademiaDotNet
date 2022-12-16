using System;
using System.Collections.Generic;

namespace DesafioFinal.Models;

public partial class Artigo
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Corpo { get; set; } = null!;

    public int IdCategoria { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
}
