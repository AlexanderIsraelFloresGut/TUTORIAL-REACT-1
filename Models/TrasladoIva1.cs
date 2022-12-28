using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TrasladoIva1
    {
        public string Modulo { get; set; } = null!;
        public string? Entidad { get; set; }
        public string? Nit { get; set; }
        public string? TipoDoc { get; set; }
        public string? Documento { get; set; }
        public DateTime? FechaDoc { get; set; }
        public string? MonedaDoc { get; set; }
        public decimal? MontoDoc { get; set; }
        public decimal? MontoLocalDoc { get; set; }
        public decimal? MontoDolarDoc { get; set; }
        public decimal? MontoAplicadoDoc { get; set; }
        public decimal? TipoCambioLocDoc { get; set; }
        public decimal? TipoCambioDolDoc { get; set; }
        public string? AplicacionDoc { get; set; }
        public string? TipoDoc2 { get; set; }
        public string? Documento2 { get; set; }
        public DateTime? FechaDoc2 { get; set; }
        public string? MonedaDoc2 { get; set; }
        public decimal? MontoDoc2 { get; set; }
        public decimal? MontoLocalDoc2 { get; set; }
        public decimal? MontoDolarDoc2 { get; set; }
        public decimal? MontoAplicadoDoc2 { get; set; }
        public decimal? ImpuestoDoc2 { get; set; }
        public decimal? TipoCambioLocDoc2 { get; set; }
        public decimal? TipoCambioDolDoc2 { get; set; }
        public string? AplicacionDoc2 { get; set; }
        public string? Asiento { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string? DocumentoFiscal2 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? DocPagoRet { get; set; }
        public string? TipoPagoRet { get; set; }
    }
}
