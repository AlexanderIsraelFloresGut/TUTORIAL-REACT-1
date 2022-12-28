using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwMputilizadaAb
    {
        public long OpNo { get; set; }
        public string Articulo1 { get; set; } = null!;
        public string NombreArticulo { get; set; } = null!;
        public decimal? Libras { get; set; }
        public decimal? CostoMp { get; set; }
        public string Lote { get; set; } = null!;
        public string Empresa { get; set; } = null!;
    }
}
