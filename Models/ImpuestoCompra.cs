using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpuestoCompra
    {
        public ImpuestoCompra()
        {
            ArancelImpuestos = new HashSet<ArancelImpuesto>();
            ExcepcionArancelImps = new HashSet<ExcepcionArancelImp>();
        }

        public string ImpuestoCompra1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string FormulaOk { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ImpuestoDonde ImpuestoDonde { get; set; } = null!;
        public virtual ImpuestoExpand ImpuestoExpand { get; set; } = null!;
        public virtual ImpuestoFormula ImpuestoFormula { get; set; } = null!;
        public virtual ICollection<ArancelImpuesto> ArancelImpuestos { get; set; }
        public virtual ICollection<ExcepcionArancelImp> ExcepcionArancelImps { get; set; }
    }
}
