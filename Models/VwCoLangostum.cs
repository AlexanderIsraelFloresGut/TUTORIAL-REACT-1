using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwCoLangostum
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Embarque { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public string? Proveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal Lbs { get; set; }
        public decimal Lbsr { get; set; }
        public decimal? PrecioC { get; set; }
        public decimal? Totalc { get; set; }
        public decimal? Preciou { get; set; }
        public decimal? Totalu { get; set; }
        public string? Referencia { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
