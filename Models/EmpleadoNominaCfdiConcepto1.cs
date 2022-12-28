using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoNominaCfdiConcepto1
    {
        public int Id { get; set; }
        public string Empleado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string Recibo { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Clave { get; set; }
        public string? Concepto { get; set; }
        public decimal? TotalGravado { get; set; }
        public decimal? TotalExento { get; set; }
        public string? Dias { get; set; }
        public decimal? Descuento { get; set; }
        public string? Horas { get; set; }
        public decimal? Importe { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
