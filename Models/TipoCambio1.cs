using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCambio1
    {
        public TipoCambio1()
        {
            CuentaContable1s = new HashSet<CuentaContable1>();
            SubtipoDocCc1s = new HashSet<SubtipoDocCc1>();
            SubtipoDocCp1s = new HashSet<SubtipoDocCp1>();
            TipoCambioHist1s = new HashSet<TipoCambioHist1>();
        }

        public string TipoCambio { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable1> CuentaContable1s { get; set; }
        public virtual ICollection<SubtipoDocCc1> SubtipoDocCc1s { get; set; }
        public virtual ICollection<SubtipoDocCp1> SubtipoDocCp1s { get; set; }
        public virtual ICollection<TipoCambioHist1> TipoCambioHist1s { get; set; }
    }
}
