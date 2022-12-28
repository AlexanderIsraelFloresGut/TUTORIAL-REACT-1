using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCambio
    {
        public TipoCambio()
        {
            CuentaContables = new HashSet<CuentaContable>();
            TipoCambioHists = new HashSet<TipoCambioHist>();
        }

        public string TipoCambio1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable> CuentaContables { get; set; }
        public virtual ICollection<TipoCambioHist> TipoCambioHists { get; set; }
    }
}
