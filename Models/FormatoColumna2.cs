using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoColumna2
    {
        public string Formato { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public string Cantidad { get; set; } = null!;
        public string Monto { get; set; } = null!;
        public string Porcentaje { get; set; } = null!;
        public string Costo { get; set; } = null!;
        public string Utilidad { get; set; } = null!;
        public string PorcentajeUtil { get; set; } = null!;
        public string Descuento { get; set; } = null!;
        public string PorcentajeDesc { get; set; } = null!;
        public string? AcumPeriodo { get; set; }
        public string Impuesto1 { get; set; } = null!;
        public string Impuesto2 { get; set; } = null!;
        public string? AcumMes { get; set; }
        public string? AcumAno { get; set; }
        public string? AcumPerAnt { get; set; }
        public string? AcumMesAnt { get; set; }
        public string? AcumAnoAnt { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Formato2 FormatoNavigation { get; set; } = null!;
    }
}
