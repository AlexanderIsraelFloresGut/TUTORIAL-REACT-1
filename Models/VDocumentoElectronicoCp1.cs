using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VDocumentoElectronicoCp1
    {
        public string? Tipodocumento { get; set; }
        public string Factura { get; set; } = null!;
        public string? Anulada { get; set; }
        public string Proveedor { get; set; } = null!;
        public string? Estado { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldoretencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Moneda { get; set; } = null!;
        public string? Rowpointer { get; set; }
        public string Tabla { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
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
