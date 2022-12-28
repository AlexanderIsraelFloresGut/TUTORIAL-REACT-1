using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoVersionBi
    {
        public PresupuestoVersionBi()
        {
            PresupuestoCentroBis = new HashSet<PresupuestoCentroBi>();
            PresupuestoCuentaBis = new HashSet<PresupuestoCuentaBi>();
            PresupuestoDetalleBis = new HashSet<PresupuestoDetalleBi>();
            PresupuestoTipocamBis = new HashSet<PresupuestoTipocamBi>();
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

        public virtual PresupuestoBi PresupuestoNavigation { get; set; } = null!;
        public virtual ICollection<PresupuestoCentroBi> PresupuestoCentroBis { get; set; }
        public virtual ICollection<PresupuestoCuentaBi> PresupuestoCuentaBis { get; set; }
        public virtual ICollection<PresupuestoDetalleBi> PresupuestoDetalleBis { get; set; }
        public virtual ICollection<PresupuestoTipocamBi> PresupuestoTipocamBis { get; set; }
    }
}
