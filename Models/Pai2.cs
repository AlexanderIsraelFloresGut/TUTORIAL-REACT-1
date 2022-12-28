using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pai2
    {
        public Pai2()
        {
            Cliente2s = new HashSet<Cliente2>();
            DivisionGeografica12s = new HashSet<DivisionGeografica12>();
            DivisionGeografica32s = new HashSet<DivisionGeografica32>();
            DivisionGeografica42s = new HashSet<DivisionGeografica42>();
            Empleado2PaisDirecNavigations = new HashSet<Empleado2>();
            Empleado2PaisNavigations = new HashSet<Empleado2>();
            Factura2s = new HashSet<Factura2>();
            Nit2s = new HashSet<Nit2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            Pedido2s = new HashSet<Pedido2>();
            Proveedor2s = new HashSet<Proveedor2>();
            RegionDet2s = new HashSet<RegionDet2>();
        }

        public string Pais { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
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
        public string? CtrGastCom { get; set; }
        public string? CtaGastCom { get; set; }
        public string? CtrContado { get; set; }
        public string? CtaContado { get; set; }
        public string? CtrCxc { get; set; }
        public string? CtaCxc { get; set; }
        public string? CtrLxc { get; set; }
        public string? CtaLxc { get; set; }
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
        public string? CtrLxp { get; set; }
        public string? CtaLxp { get; set; }
        public string? CtrCreditoCxp { get; set; }
        public string? CtaCreditoCxp { get; set; }
        public string? CtrDebitoCxp { get; set; }
        public string? CtaDebitoCxp { get; set; }
        public string? CtrCxp { get; set; }
        public string? CtaCxp { get; set; }
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
        public string? CtrDescBonif { get; set; }
        public string? CtaDescBonif { get; set; }
        public string? CtrDevVentas { get; set; }
        public string? CtaDevVentas { get; set; }
        public string? CtrIntCorriente { get; set; }
        public string? CtaIntCorriente { get; set; }
        public string? CodigoIso { get; set; }
        public string? EtiquetaDivGeo1 { get; set; }
        public string? EtiquetaDivGeo2 { get; set; }
        public string? Moneda { get; set; }
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
        public string? EtiquetaDivGeo3 { get; set; }
        public string? EtiquetaDivGeo4 { get; set; }
        public string? UPais { get; set; }
        public string? CtrRentaCxp { get; set; }
        public string? CtaRentaCxp { get; set; }
        public string? CtrPensionOnpCxp { get; set; }
        public string? CtaPensionOnpCxp { get; set; }
        public string? CtrPensionAfpCxp { get; set; }
        public string? CtaPensionAfpCxp { get; set; }
        public string? CtrComision { get; set; }
        public string? CtaComision { get; set; }
        public string? CtaAdvalorem { get; set; }
        public string? CtrAdvalorem { get; set; }
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
        public virtual CentroCuentum2? Ct24 { get; set; }
        public virtual CentroCuentum2? Ct25 { get; set; }
        public virtual CentroCuentum2? Ct26 { get; set; }
        public virtual CentroCuentum2? Ct27 { get; set; }
        public virtual CentroCuentum2? Ct28 { get; set; }
        public virtual CentroCuentum2? Ct29 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct30 { get; set; }
        public virtual CentroCuentum2? Ct31 { get; set; }
        public virtual CentroCuentum2? Ct32 { get; set; }
        public virtual CentroCuentum2? Ct33 { get; set; }
        public virtual CentroCuentum2? Ct34 { get; set; }
        public virtual CentroCuentum2? Ct35 { get; set; }
        public virtual CentroCuentum2? Ct36 { get; set; }
        public virtual CentroCuentum2? Ct37 { get; set; }
        public virtual CentroCuentum2? Ct38 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? Ct6 { get; set; }
        public virtual CentroCuentum2? Ct7 { get; set; }
        public virtual CentroCuentum2? Ct8 { get; set; }
        public virtual CentroCuentum2? Ct9 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual Direccion2 DireccionNavigation { get; set; } = null!;
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DivisionGeografica12> DivisionGeografica12s { get; set; }
        public virtual ICollection<DivisionGeografica32> DivisionGeografica32s { get; set; }
        public virtual ICollection<DivisionGeografica42> DivisionGeografica42s { get; set; }
        public virtual ICollection<Empleado2> Empleado2PaisDirecNavigations { get; set; }
        public virtual ICollection<Empleado2> Empleado2PaisNavigations { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Nit2> Nit2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
        public virtual ICollection<RegionDet2> RegionDet2s { get; set; }
    }
}
