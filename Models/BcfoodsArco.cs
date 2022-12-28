using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BcfoodsArco
    {
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Impuesto { get; set; } = null!;
        public string? CodigoArancel { get; set; }
        public string? CodigoCorporativo { get; set; }
        public string Imp1AfectaCosto { get; set; } = null!;
        public decimal? PorcVariacCant { get; set; }
        public decimal? UltPrecUnitario { get; set; }
        public string? UltProveedor { get; set; }
        public string? UltProveedorNombre { get; set; }
        public string? UltMoneda { get; set; }
        public DateTime? UltFechaCotiza { get; set; }
        public Guid Rowpointer { get; set; }
    }
}
