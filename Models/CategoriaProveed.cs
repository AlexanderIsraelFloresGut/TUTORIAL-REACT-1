using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CategoriaProveed
    {
        public CategoriaProveed()
        {
            Proveedors = new HashSet<Proveedor>();
        }

        public string CategoriaProveed1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? CtrCxp { get; set; }
        public string? CtaCxp { get; set; }
        public string? CtrLxp { get; set; }
        public string? CtaLxp { get; set; }
        public string? CtrCreditoCxp { get; set; }
        public string? CtaCreditoCxp { get; set; }
        public string? CtrDebitoCxp { get; set; }
        public string? CtaDebitoCxp { get; set; }
        public string? CtrProntoPagCxp { get; set; }
        public string? CtaProntoPagCxp { get; set; }
        public string? CtrComisionCxp { get; set; }
        public string? CtaComisionCxp { get; set; }
        public string? CtrImpuesto1Cxp { get; set; }
        public string? CtaImpuesto1Cxp { get; set; }
        public string? CtrImpuesto2Cxp { get; set; }
        public string? CtaImpuesto2Cxp { get; set; }
        public string? CtrRubro1Cxp { get; set; }
        public string? CtaRubro1Cxp { get; set; }
        public string? CtrRubro2Cxp { get; set; }
        public string? CtaRubro2Cxp { get; set; }
        public string? CtrAnticipoCxp { get; set; }
        public string? CtaAnticipoCxp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CtrAjusteRedondeo { get; set; }
        public string? CtaAjusteRedondeo { get; set; }
        public string? CtrRenta { get; set; }
        public string? CtaRenta { get; set; }
        public string? CtrPensionOnp { get; set; }
        public string? CtaPensionOnp { get; set; }
        public string? CtrPensionAfp { get; set; }
        public string? CtaPensionAfp { get; set; }
        public string? CtrComision { get; set; }
        public string? CtaComision { get; set; }
        public string? CtrAdvalorem { get; set; }
        public string? CtaAdvalorem { get; set; }

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct10 { get; set; }
        public virtual CentroCuentum? Ct11 { get; set; }
        public virtual CentroCuentum? Ct12 { get; set; }
        public virtual CentroCuentum? Ct13 { get; set; }
        public virtual CentroCuentum? Ct14 { get; set; }
        public virtual CentroCuentum? Ct15 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? Ct7 { get; set; }
        public virtual CentroCuentum? Ct8 { get; set; }
        public virtual CentroCuentum? Ct9 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
