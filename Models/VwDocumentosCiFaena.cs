using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwDocumentosCiFaena
    {
        public int AuditTransInv { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Aplicacion { get; set; }
        public string? Faena { get; set; }
        public string Referencia { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Bodega { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? CostoTotFiscLoc { get; set; }
        public decimal Total { get; set; }
        public string? Consecutivo { get; set; }
        public string? PaqueteInventario { get; set; }
    }
}
