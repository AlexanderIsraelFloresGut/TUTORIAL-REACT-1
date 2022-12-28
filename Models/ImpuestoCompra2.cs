using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpuestoCompra2
    {
        public ImpuestoCompra2()
        {
            ArancelImpuesto2s = new HashSet<ArancelImpuesto2>();
            ExcepcionArancelImp2s = new HashSet<ExcepcionArancelImp2>();
        }

        public string ImpuestoCompra { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string FormulaOk { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ImpuestoDonde2 ImpuestoDonde2 { get; set; } = null!;
        public virtual ImpuestoExpand2 ImpuestoExpand2 { get; set; } = null!;
        public virtual ImpuestoFormula2 ImpuestoFormula2 { get; set; } = null!;
        public virtual ICollection<ArancelImpuesto2> ArancelImpuesto2s { get; set; }
        public virtual ICollection<ExcepcionArancelImp2> ExcepcionArancelImp2s { get; set; }
    }
}
