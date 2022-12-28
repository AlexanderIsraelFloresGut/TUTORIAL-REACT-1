﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VDocumentoElectronicoCartum1
    {
        public string Tipodocumento { get; set; } = null!;
        public string? Factura { get; set; }
        public string? Estado { get; set; }
        public int Totalfactura { get; set; }
        public int Saldo { get; set; }
        public int Totalfacturaretencion { get; set; }
        public string Monedafactura { get; set; } = null!;
        public string Tabla { get; set; } = null!;
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
        public string GeneraCartaPorte { get; set; } = null!;
        public string? ErrorWs { get; set; }
        public string? ErrorSoftland { get; set; }
        public string? FirmaGt { get; set; }
        public string? GuuidGt { get; set; }
        public string? EmailCfdi { get; set; }
        public DateTime Fecha { get; set; }
        public string? DocumentoFiscal { get; set; }
    }
}
