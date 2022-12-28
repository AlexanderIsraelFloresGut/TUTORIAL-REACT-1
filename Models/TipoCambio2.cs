using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCambio2
    {
        public TipoCambio2()
        {
            CuentaContable2s = new HashSet<CuentaContable2>();
            TipoCambioHist2s = new HashSet<TipoCambioHist2>();
        }

        public string TipoCambio { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable2> CuentaContable2s { get; set; }
        public virtual ICollection<TipoCambioHist2> TipoCambioHist2s { get; set; }
    }
}
