using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VDocumentoElectronico1
    {
        public string? Tipodocumento { get; set; }
        public string Factura { get; set; } = null!;
        public string? Anulada { get; set; }
        public string Cliente { get; set; } = null!;
        public string? Estado { get; set; }
        public decimal Totalfactura { get; set; }
        public decimal Saldo { get; set; }
        public decimal? Totalfacturaretencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Monedafactura { get; set; } = null!;
        public string? Rowpointer { get; set; }
        public string Tabla { get; set; } = null!;
        public DateTime Recorddate { get; set; }
        public string Createdby { get; set; } = null!;
        public string Updatedby { get; set; } = null!;
        public DateTime Createdate { get; set; }
        public string? Foliosat { get; set; }
        public string Enviado { get; set; } = null!;
        public string? NitEmisor { get; set; }
        public string? NitReceptor { get; set; }
        public string Aceptado { get; set; } = null!;
        public string? AceptacionRechazo { get; set; }
        public string? DocumentoElectronico { get; set; }
        public string? NombrePdf { get; set; }
        public string? NombreXml { get; set; }
        public string? EstadoCartaPorte { get; set; }
        public string? GeneraCartaPorte { get; set; }
        public string? ErrorWs { get; set; }
        public string? ErrorSoftland { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string? FirmaGt { get; set; }
        public string? GuuidGt { get; set; }
    }
}
