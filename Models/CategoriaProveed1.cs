using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CategoriaProveed1
    {
        public CategoriaProveed1()
        {
            Proveedor1s = new HashSet<Proveedor1>();
        }

        public string CategoriaProveed { get; set; } = null!;
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
        public string? CtrGastoRenta { get; set; }
        public string? CtaGastoRenta { get; set; }
        public string? CtrIgvNoDom { get; set; }
        public string? CtaIgvNoDom { get; set; }
        public string? CtrImpBolsaCxp { get; set; }
        public string? CtaImpBolsaCxp { get; set; }

        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? Ct1 { get; set; }
        public virtual CentroCuentum1? Ct10 { get; set; }
        public virtual CentroCuentum1? Ct11 { get; set; }
        public virtual CentroCuentum1? Ct12 { get; set; }
        public virtual CentroCuentum1? Ct13 { get; set; }
        public virtual CentroCuentum1? Ct14 { get; set; }
        public virtual CentroCuentum1? Ct15 { get; set; }
        public virtual CentroCuentum1? Ct16 { get; set; }
        public virtual CentroCuentum1? Ct17 { get; set; }
        public virtual CentroCuentum1? Ct18 { get; set; }
        public virtual CentroCuentum1? Ct2 { get; set; }
        public virtual CentroCuentum1? Ct3 { get; set; }
        public virtual CentroCuentum1? Ct4 { get; set; }
        public virtual CentroCuentum1? Ct5 { get; set; }
        public virtual CentroCuentum1? Ct6 { get; set; }
        public virtual CentroCuentum1? Ct7 { get; set; }
        public virtual CentroCuentum1? Ct8 { get; set; }
        public virtual CentroCuentum1? Ct9 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
    }
}
