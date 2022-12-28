using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwFacturaPaquete
    {
        public string Factura { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Anulada { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string? NombreCliente { get; set; }
        public string Cobrador { get; set; } = null!;
        public string NombreCobrador { get; set; } = null!;
        public decimal TotalMercaderia { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal TotalImpuesto1Encabezado { get; set; }
        public decimal TotalFactura { get; set; }
        public string Articulo { get; set; } = null!;
        public string NombreArticulo { get; set; } = null!;
        public decimal PesoBruto { get; set; }
        public decimal PesoNeto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal DescTotLinea { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Paquete { get; set; }
        public decimal? PrecioPresentacion { get; set; }
    }
}
