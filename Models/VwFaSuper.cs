using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwFaSuper
    {
        public string Factura { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string CodCliente { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string CodigoArt { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Producto { get; set; }
        public decimal PaqLb { get; set; }
        public decimal? Paquete { get; set; }
        public decimal? PrecPaq { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal? SubtotalFact { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal? TotalFact { get; set; }
    }
}
