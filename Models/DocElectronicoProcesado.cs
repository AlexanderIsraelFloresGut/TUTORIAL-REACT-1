using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocElectronicoProcesado
    {
        public string TipoDoc { get; set; } = null!;
        public string NumeroDoc { get; set; } = null!;
        public string NitEmisor { get; set; } = null!;
        public string Modulo { get; set; } = null!;
        public string? EmailEmisor { get; set; }
        public string GlnEmisor { get; set; } = null!;
        public string NitReceptor { get; set; } = null!;
        public string? EmailReceptor { get; set; }
        public string GlnReceptor { get; set; } = null!;
        public string Enviado { get; set; } = null!;
        public string? Aceptado { get; set; }
        public string? CargadoErp { get; set; }
        public decimal? NumeroRecepcion { get; set; }
        public int? CantidadImpresiones { get; set; }
        public string? DocumentoElectronico { get; set; }
        public string? AceptacionRechazo { get; set; }
        public string? NombrePdf { get; set; }
        public string? FirmaDocumento { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; } = null!;
        public string? FolioSat { get; set; }
        public string? CadenaOriginal { get; set; }
        public string? Nocertificado { get; set; }
        public string? Fechatimbrado { get; set; }
        public string? Nocertificadosat { get; set; }
        public string? Sellosat { get; set; }
        public string? Sellocdf { get; set; }
        public string? NombreXml { get; set; }
        public string? ContieneErrores { get; set; }
        public string? NumeroCae { get; set; }
        public string? NumeroDte { get; set; }
        public string? XmlTemp { get; set; }
        public string GeneraCartaPorte { get; set; } = null!;
        public string? EstadoCartaPorte { get; set; }
        public string? UltimoError { get; set; }
        public string ErrorWs { get; set; } = null!;
        public string ErrorSoftland { get; set; } = null!;
        public string? GuuidGt { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
