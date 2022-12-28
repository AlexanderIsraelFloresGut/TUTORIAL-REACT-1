using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpuestoCompra1
    {
        public ImpuestoCompra1()
        {
            ArancelImpuesto1s = new HashSet<ArancelImpuesto1>();
            ExcepcionArancelImp1s = new HashSet<ExcepcionArancelImp1>();
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

        public virtual ImpuestoDonde1 ImpuestoDonde1 { get; set; } = null!;
        public virtual ImpuestoExpand1 ImpuestoExpand1 { get; set; } = null!;
        public virtual ImpuestoFormula1 ImpuestoFormula1 { get; set; } = null!;
        public virtual ICollection<ArancelImpuesto1> ArancelImpuesto1s { get; set; }
        public virtual ICollection<ExcepcionArancelImp1> ExcepcionArancelImp1s { get; set; }
    }
}
