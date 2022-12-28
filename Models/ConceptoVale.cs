using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoVale
    {
        public ConceptoVale()
        {
            DocsSoportes = new HashSet<DocsSoporte>();
            Vales = new HashSet<Vale>();
        }

        public string ConceptoVale1 { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Imp1AfectaCosto { get; set; } = null!;
        public string UsaCtaConcepto { get; set; } = null!;
        public string? CtrCtoRetAsum { get; set; }
        public string? CtaCtbRetAsum { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? ModeloRetencion { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual CentroCuentum? Ct { get; set; }
        public virtual ModeloRetencion? ModeloRetencionNavigation { get; set; }
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
        public virtual ICollection<Vale> Vales { get; set; }
    }
}
