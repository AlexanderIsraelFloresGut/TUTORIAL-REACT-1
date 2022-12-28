using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CategoriaCliente2
    {
        public CategoriaCliente2()
        {
            Cliente2s = new HashSet<Cliente2>();
            ReglaDescuento2s = new HashSet<ReglaDescuento2>();
        }

        public string CategoriaCliente { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? CtrVentas { get; set; }
        public string? CtaVentas { get; set; }
        public string? CtrDescGral { get; set; }
        public string? CtaDescGral { get; set; }
        public string? CtrCostVent { get; set; }
        public string? CtaCostVent { get; set; }
        public string? CtrDescLin { get; set; }
        public string? CtaDescLin { get; set; }
        public string? CtrCostLin { get; set; }
        public string? CtaCostLin { get; set; }
        public string? CtrVendCom { get; set; }
        public string? CtaVendCom { get; set; }
        public string? CtrCobrCom { get; set; }
        public string? CtaCobrCom { get; set; }
        public string? CtrCxc { get; set; }
        public string? CtaCxc { get; set; }
        public string? CtrLxc { get; set; }
        public string? CtaLxc { get; set; }
        public string? CtrContado { get; set; }
        public string? CtaContado { get; set; }
        public string? CtrProntoPagCxc { get; set; }
        public string? CtaProntoPagCxc { get; set; }
        public string? CtrIntMoraCxc { get; set; }
        public string? CtaIntMoraCxc { get; set; }
        public string? CtrRecibosCxc { get; set; }
        public string? CtaRecibosCxc { get; set; }
        public string? CtrDebitoCxc { get; set; }
        public string? CtaDebitoCxc { get; set; }
        public string? CtrCreditoCxc { get; set; }
        public string? CtaCreditoCxc { get; set; }
        public string? CtrImpuesto1Cxc { get; set; }
        public string? CtaImpuesto1Cxc { get; set; }
        public string? CtrImpuesto2Cxc { get; set; }
        public string? CtaImpuesto2Cxc { get; set; }
        public string? CtrRubro1Cxc { get; set; }
        public string? CtaRubro1Cxc { get; set; }
        public string? CtrRubro2Cxc { get; set; }
        public string? CtaRubro2Cxc { get; set; }
        public string? CtrAnticipoCxc { get; set; }
        public string? CtaAnticipoCxc { get; set; }
        public string? CtrDescBonif { get; set; }
        public string? CtaDescBonif { get; set; }
        public string? CtrDevVentas { get; set; }
        public string? CtaDevVentas { get; set; }
        public string? CtrIntCorriente { get; set; }
        public string? CtaIntCorriente { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CtrVentasExen { get; set; }
        public string? CtaVentasExen { get; set; }
        public string? CtrAjusteRedondeo { get; set; }
        public string? CtaAjusteRedondeo { get; set; }
        public string? CtrCobrDudosa { get; set; }
        public string? CtaCobrDudosa { get; set; }

        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct10 { get; set; }
        public virtual CentroCuentum2? Ct11 { get; set; }
        public virtual CentroCuentum2? Ct12 { get; set; }
        public virtual CentroCuentum2? Ct13 { get; set; }
        public virtual CentroCuentum2? Ct14 { get; set; }
        public virtual CentroCuentum2? Ct15 { get; set; }
        public virtual CentroCuentum2? Ct16 { get; set; }
        public virtual CentroCuentum2? Ct17 { get; set; }
        public virtual CentroCuentum2? Ct18 { get; set; }
        public virtual CentroCuentum2? Ct19 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct20 { get; set; }
        public virtual CentroCuentum2? Ct21 { get; set; }
        public virtual CentroCuentum2? Ct22 { get; set; }
        public virtual CentroCuentum2? Ct23 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? Ct6 { get; set; }
        public virtual CentroCuentum2? Ct7 { get; set; }
        public virtual CentroCuentum2? Ct8 { get; set; }
        public virtual CentroCuentum2? Ct9 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<ReglaDescuento2> ReglaDescuento2s { get; set; }
    }
}
