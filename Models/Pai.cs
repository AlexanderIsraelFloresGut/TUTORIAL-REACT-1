using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Pai
    {
        public Pai()
        {
            Clientes = new HashSet<Cliente>();
            DivisionGeografica1s = new HashSet<DivisionGeografica1>();
            DivisionGeografica3s = new HashSet<DivisionGeografica3>();
            DivisionGeografica4s = new HashSet<DivisionGeografica4>();
            EmpleadoPaisDirecNavigations = new HashSet<Empleado>();
            EmpleadoPaisNavigations = new HashSet<Empleado>();
            Facturas = new HashSet<Factura>();
            Nits = new HashSet<Nit>();
            OrdenCompras = new HashSet<OrdenCompra>();
            Pedidos = new HashSet<Pedido>();
            Proveedors = new HashSet<Proveedor>();
            RegionDets = new HashSet<RegionDet>();
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

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct10 { get; set; }
        public virtual CentroCuentum? Ct11 { get; set; }
        public virtual CentroCuentum? Ct12 { get; set; }
        public virtual CentroCuentum? Ct13 { get; set; }
        public virtual CentroCuentum? Ct14 { get; set; }
        public virtual CentroCuentum? Ct15 { get; set; }
        public virtual CentroCuentum? Ct16 { get; set; }
        public virtual CentroCuentum? Ct17 { get; set; }
        public virtual CentroCuentum? Ct18 { get; set; }
        public virtual CentroCuentum? Ct19 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct20 { get; set; }
        public virtual CentroCuentum? Ct21 { get; set; }
        public virtual CentroCuentum? Ct22 { get; set; }
        public virtual CentroCuentum? Ct23 { get; set; }
        public virtual CentroCuentum? Ct24 { get; set; }
        public virtual CentroCuentum? Ct25 { get; set; }
        public virtual CentroCuentum? Ct26 { get; set; }
        public virtual CentroCuentum? Ct27 { get; set; }
        public virtual CentroCuentum? Ct28 { get; set; }
        public virtual CentroCuentum? Ct29 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct30 { get; set; }
        public virtual CentroCuentum? Ct31 { get; set; }
        public virtual CentroCuentum? Ct32 { get; set; }
        public virtual CentroCuentum? Ct33 { get; set; }
        public virtual CentroCuentum? Ct34 { get; set; }
        public virtual CentroCuentum? Ct35 { get; set; }
        public virtual CentroCuentum? Ct36 { get; set; }
        public virtual CentroCuentum? Ct37 { get; set; }
        public virtual CentroCuentum? Ct38 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? Ct7 { get; set; }
        public virtual CentroCuentum? Ct8 { get; set; }
        public virtual CentroCuentum? Ct9 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual Direccion DireccionNavigation { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DivisionGeografica1> DivisionGeografica1s { get; set; }
        public virtual ICollection<DivisionGeografica3> DivisionGeografica3s { get; set; }
        public virtual ICollection<DivisionGeografica4> DivisionGeografica4s { get; set; }
        public virtual ICollection<Empleado> EmpleadoPaisDirecNavigations { get; set; }
        public virtual ICollection<Empleado> EmpleadoPaisNavigations { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Nit> Nits { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<RegionDet> RegionDets { get; set; }
    }
}
