using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoNominaCfdi2
    {
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string? ArchivoXml { get; set; }
        public string? Enviado { get; set; }
        public string? Error { get; set; }
        public string? Uuid { get; set; }
        public string? CadenaOriginal { get; set; }
        public string? NumeroCertificadoCia { get; set; }
        public string? FechaTimbrado { get; set; }
        public string? NumeroCertificadoSat { get; set; }
        public string? SelloSat { get; set; }
        public string? SelloCfd { get; set; }
        public byte[]? ArchivoPdf { get; set; }
        public string Recibo { get; set; } = null!;
        public string? RegPatronal { get; set; }
        public decimal? FaltasPeriodo { get; set; }
        public decimal? DiasVac { get; set; }
        public decimal? DiasIncap { get; set; }
        public string? Curp { get; set; }
        public decimal? HorasExtra { get; set; }
        public decimal? DiasPagados { get; set; }
        public string? XmlTemp { get; set; }
        public int? Consecutivo { get; set; }
        public decimal? Total { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Descuentos { get; set; }
        public decimal? Impuestos { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string EnviadoSch { get; set; } = null!;
    }
}
