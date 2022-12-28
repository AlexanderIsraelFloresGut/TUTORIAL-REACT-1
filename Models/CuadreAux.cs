using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuadreAux
    {
        public int CuadresCg { get; set; }
        public string TablaOrigen { get; set; } = null!;
        public string GuidOrigen { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; } = null!;
        public string? Asiento { get; set; }
        public decimal DebitoLoc { get; set; }
        public decimal DebitoDol { get; set; }
        public decimal CreditoLoc { get; set; }
        public decimal CreditoDol { get; set; }
        public string Origen { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
