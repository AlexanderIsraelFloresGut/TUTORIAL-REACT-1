using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwComprasalinsasoftland
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Embarque { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public string CategoriaProveed { get; set; } = null!;
        public string? Codproveedor { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Especie { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string NombreArticulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal Libras { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal? PUnitc { get; set; }
        public decimal? Comprac { get; set; }
    }
}
