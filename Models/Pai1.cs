using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pai1
    {
        public Pai1()
        {
            CartaPorteArrendatarios = new HashSet<CartaPorteArrendatario>();
            CartaPorteNotificados = new HashSet<CartaPorteNotificado>();
            CartaPorteOperadors = new HashSet<CartaPorteOperador>();
            CartaPortePropietarios = new HashSet<CartaPortePropietario>();
            CartaPorteUbicacions = new HashSet<CartaPorteUbicacion>();
            CartaPortes = new HashSet<CartaPorte>();
            Cliente1s = new HashSet<Cliente1>();
            DivisionGeografica11s = new HashSet<DivisionGeografica11>();
            DivisionGeografica31s = new HashSet<DivisionGeografica31>();
            DivisionGeografica41s = new HashSet<DivisionGeografica41>();
            Empleado1PaisDirecNavigations = new HashSet<Empleado1>();
            Empleado1PaisNavigations = new HashSet<Empleado1>();
            Factura1s = new HashSet<Factura1>();
            Nit1s = new HashSet<Nit1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            Pedido1s = new HashSet<Pedido1>();
            Proveedor1s = new HashSet<Proveedor1>();
            RegionDet1s = new HashSet<RegionDet1>();
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
        public string? CtrGastoRenta { get; set; }
        public string? CtaGastoRenta { get; set; }
        public string? CtrIgvNoDom { get; set; }
        public string? CtaIgvNoDom { get; set; }
        public string? CtrImpBolsaCxc { get; set; }
        public string? CtaImpBolsaCxc { get; set; }
        public string? CtrImpBolsaCxp { get; set; }
        public string? CtaImpBolsaCxp { get; set; }
        public string? GentMasc { get; set; }
        public string? GentFem { get; set; }

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
        public virtual CentroCuentum1? Ct19 { get; set; }
        public virtual CentroCuentum1? Ct2 { get; set; }
        public virtual CentroCuentum1? Ct20 { get; set; }
        public virtual CentroCuentum1? Ct21 { get; set; }
        public virtual CentroCuentum1? Ct22 { get; set; }
        public virtual CentroCuentum1? Ct23 { get; set; }
        public virtual CentroCuentum1? Ct24 { get; set; }
        public virtual CentroCuentum1? Ct25 { get; set; }
        public virtual CentroCuentum1? Ct26 { get; set; }
        public virtual CentroCuentum1? Ct27 { get; set; }
        public virtual CentroCuentum1? Ct28 { get; set; }
        public virtual CentroCuentum1? Ct29 { get; set; }
        public virtual CentroCuentum1? Ct3 { get; set; }
        public virtual CentroCuentum1? Ct30 { get; set; }
        public virtual CentroCuentum1? Ct31 { get; set; }
        public virtual CentroCuentum1? Ct32 { get; set; }
        public virtual CentroCuentum1? Ct33 { get; set; }
        public virtual CentroCuentum1? Ct34 { get; set; }
        public virtual CentroCuentum1? Ct35 { get; set; }
        public virtual CentroCuentum1? Ct36 { get; set; }
        public virtual CentroCuentum1? Ct37 { get; set; }
        public virtual CentroCuentum1? Ct38 { get; set; }
        public virtual CentroCuentum1? Ct39 { get; set; }
        public virtual CentroCuentum1? Ct4 { get; set; }
        public virtual CentroCuentum1? Ct40 { get; set; }
        public virtual CentroCuentum1? Ct41 { get; set; }
        public virtual CentroCuentum1? Ct42 { get; set; }
        public virtual CentroCuentum1? Ct5 { get; set; }
        public virtual CentroCuentum1? Ct6 { get; set; }
        public virtual CentroCuentum1? Ct7 { get; set; }
        public virtual CentroCuentum1? Ct8 { get; set; }
        public virtual CentroCuentum1? Ct9 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual Direccion1 DireccionNavigation { get; set; } = null!;
        public virtual ICollection<CartaPorteArrendatario> CartaPorteArrendatarios { get; set; }
        public virtual ICollection<CartaPorteNotificado> CartaPorteNotificados { get; set; }
        public virtual ICollection<CartaPorteOperador> CartaPorteOperadors { get; set; }
        public virtual ICollection<CartaPortePropietario> CartaPortePropietarios { get; set; }
        public virtual ICollection<CartaPorteUbicacion> CartaPorteUbicacions { get; set; }
        public virtual ICollection<CartaPorte> CartaPortes { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DivisionGeografica11> DivisionGeografica11s { get; set; }
        public virtual ICollection<DivisionGeografica31> DivisionGeografica31s { get; set; }
        public virtual ICollection<DivisionGeografica41> DivisionGeografica41s { get; set; }
        public virtual ICollection<Empleado1> Empleado1PaisDirecNavigations { get; set; }
        public virtual ICollection<Empleado1> Empleado1PaisNavigations { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<Nit1> Nit1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
        public virtual ICollection<RegionDet1> RegionDet1s { get; set; }
    }
}
