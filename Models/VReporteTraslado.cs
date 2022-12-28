using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VReporteTraslado
    {
        public string? Factura { get; set; }
        public string Articulo { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public decimal? Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public int PrecioTotal { get; set; }
        public int TotalFactura { get; set; }
        public string? Descripcion { get; set; }
        public int TotalImpuesto1 { get; set; }
        public int TotalMercaderia { get; set; }
        public string? Nombre { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Contribuyente { get; set; }
        public string? MonedaFactura { get; set; }
        public string? FolioSat { get; set; }
        public string? Fechatimbrado { get; set; }
        public string? Nocertificado { get; set; }
        public string? Nocertificadosat { get; set; }
        public string? NitEmisor { get; set; }
        public string? NitReceptor { get; set; }
        public int Totalfactura1 { get; set; }
        public string? Direccion { get; set; }
        public string? Sellosat { get; set; }
        public string? Sellocdf { get; set; }
        public string? CadenaOriginal { get; set; }
    }
}
