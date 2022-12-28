using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoVersionBi1
    {
        public PresupuestoVersionBi1()
        {
            PresupuestoCentroBi1s = new HashSet<PresupuestoCentroBi1>();
            PresupuestoCuentaBi1s = new HashSet<PresupuestoCuentaBi1>();
            PresupuestoDetalleBi1s = new HashSet<PresupuestoDetalleBi1>();
            PresupuestoTipocamBi1s = new HashSet<PresupuestoTipocamBi1>();
        }

        public string Presupuesto { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string TipoTipocambio { get; set; } = null!;
        public decimal PromedioTipoCambio { get; set; }
        public DateTime MesInicial { get; set; }
        public DateTime MesFinal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PresupuestoBi1 PresupuestoNavigation { get; set; } = null!;
        public virtual ICollection<PresupuestoCentroBi1> PresupuestoCentroBi1s { get; set; }
        public virtual ICollection<PresupuestoCuentaBi1> PresupuestoCuentaBi1s { get; set; }
        public virtual ICollection<PresupuestoDetalleBi1> PresupuestoDetalleBi1s { get; set; }
        public virtual ICollection<PresupuestoTipocamBi1> PresupuestoTipocamBi1s { get; set; }
    }
}
