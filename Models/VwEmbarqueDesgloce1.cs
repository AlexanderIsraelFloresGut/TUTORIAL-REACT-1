using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmbarqueDesgloce1
    {
        public string Embarque { get; set; } = null!;
        public short EmbarqueLinea { get; set; }
        public string? OrdenCompra { get; set; }
        public long? Secuencia { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Lote { get; set; }
        public string Bodega { get; set; } = null!;
        public decimal CantidadRequerida { get; set; }
        public decimal? CantRecibida { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
