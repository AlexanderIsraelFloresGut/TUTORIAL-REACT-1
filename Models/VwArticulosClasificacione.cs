using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwArticulosClasificacione
    {
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? GrupoConta { get; set; }
        public string? Familia { get; set; }
        public string? Rubro { get; set; }
        public string? Talla { get; set; }
        public string? Origen { get; set; }
        public string TipoFamilia { get; set; } = null!;
    }
}
