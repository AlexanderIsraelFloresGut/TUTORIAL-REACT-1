using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoVale1
    {
        public ConceptoVale1()
        {
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            Vale1s = new HashSet<Vale1>();
        }

        public string ConceptoVale { get; set; } = null!;
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

        public virtual CentroCuentum1? C { get; set; }
        public virtual CentroCuentum1? Ct { get; set; }
        public virtual ModeloRetencion1? ModeloRetencionNavigation { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<Vale1> Vale1s { get; set; }
    }
}
