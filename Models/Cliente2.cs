using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cliente2
    {
        public Cliente2()
        {
            AutorVentum2s = new HashSet<AutorVentum2>();
            AuxiliarCc2CliDocCreditNavigations = new HashSet<AuxiliarCc2>();
            AuxiliarCc2CliDocDebitoNavigations = new HashSet<AuxiliarCc2>();
            AuxiliarCc2CliReporteCreditNavigations = new HashSet<AuxiliarCc2>();
            AuxiliarCc2CliReporteDebitoNavigations = new HashSet<AuxiliarCc2>();
            ClienteRetencion2s = new HashSet<ClienteRetencion2>();
            ClienteVendedor2s = new HashSet<ClienteVendedor2>();
            Concepto2s = new HashSet<Concepto2>();
            ContactoCliente2s = new HashSet<ContactoCliente2>();
            ContrarecibosCc2s = new HashSet<ContrarecibosCc2>();
            Despacho2s = new HashSet<Despacho2>();
            DireccEmbarque2s = new HashSet<DireccEmbarque2>();
            DocumentosCc2ClienteNavigations = new HashSet<DocumentosCc2>();
            DocumentosCc2ClienteOrigenNavigations = new HashSet<DocumentosCc2>();
            DocumentosCc2ClienteReporteNavigations = new HashSet<DocumentosCc2>();
            ExcepcionD1042s = new HashSet<ExcepcionD1042>();
            Factura2ClienteCorporacNavigations = new HashSet<Factura2>();
            Factura2ClienteDireccionNavigations = new HashSet<Factura2>();
            Factura2ClienteNavigations = new HashSet<Factura2>();
            Factura2ClienteOrigenNavigations = new HashSet<Factura2>();
            FacturaAduana2s = new HashSet<FacturaAduana2>();
            InverseCliCorporacAsocNavigation = new HashSet<Cliente2>();
            OpOperDetProd2s = new HashSet<OpOperDetProd2>();
            OrdenCliente2s = new HashSet<OrdenCliente2>();
            Pedido2ClienteCorporacNavigations = new HashSet<Pedido2>();
            Pedido2ClienteDireccionNavigations = new HashSet<Pedido2>();
            Pedido2ClienteNavigations = new HashSet<Pedido2>();
            Pedido2ClienteOrigenNavigations = new HashSet<Pedido2>();
            ReglaDescuento2s = new HashSet<ReglaDescuento2>();
            SaldoCliente2s = new HashSet<SaldoCliente2>();
        }

        public string Cliente { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? DetalleDireccion { get; set; }
        public string? Alias { get; set; }
        public string Contacto { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? DirEmbDefault { get; set; }
        public string Telefono1 { get; set; } = null!;
        public string Telefono2 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Contribuyente { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public string Multimoneda { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal SaldoCredito { get; set; }
        public decimal? SaldoNocargos { get; set; }
        public decimal? LimiteCredito { get; set; }
        public string ExcederLimite { get; set; } = null!;
        public decimal TasaInteres { get; set; }
        public decimal TasaInteresMora { get; set; }
        public DateTime FechaUltMora { get; set; }
        public DateTime FechaUltMov { get; set; }
        public string CondicionPago { get; set; } = null!;
        public string NivelPrecio { get; set; } = null!;
        public decimal Descuento { get; set; }
        public string MonedaNivel { get; set; } = null!;
        public string AceptaBackorder { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string? Vendedor { get; set; }
        public string Cobrador { get; set; } = null!;
        public string AceptaFracciones { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string ExentoImpuestos { get; set; } = null!;
        public decimal ExencionImp1 { get; set; }
        public decimal ExencionImp2 { get; set; }
        public string CobroJudicial { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string? ClaseAbc { get; set; }
        public short DiasAbastecimien { get; set; }
        public string UsaTarjeta { get; set; } = null!;
        public string? TarjetaCredito { get; set; }
        public string? TipoTarjeta { get; set; }
        public DateTime? FechaVenceTarj { get; set; }
        public string? EMail { get; set; }
        public string RequiereOc { get; set; } = null!;
        public string EsCorporacion { get; set; } = null!;
        public string? CliCorporacAsoc { get; set; }
        public string Registrardocsacorp { get; set; } = null!;
        public string UsarDirembCorp { get; set; } = null!;
        public string AplicacAbiertas { get; set; } = null!;
        public string VerifLimcredCorp { get; set; } = null!;
        public string UsarDescCorp { get; set; } = null!;
        public string DocAGenerar { get; set; } = null!;
        public string? Rubro1Cliente { get; set; }
        public string? Rubro2Cliente { get; set; }
        public string? Rubro3Cliente { get; set; }
        public string TieneConvenio { get; set; } = null!;
        public string? Notas { get; set; }
        public short DiasPromedAtraso { get; set; }
        public string? Rubro1Cli { get; set; }
        public string? Rubro2Cli { get; set; }
        public string? Rubro3Cli { get; set; }
        public string? Rubro4Cli { get; set; }
        public string? Rubro5Cli { get; set; }
        public string Asocobligcontfact { get; set; } = null!;
        public string? Rubro4Cliente { get; set; }
        public string? Rubro5Cliente { get; set; }
        public string? Rubro6Cliente { get; set; }
        public string? Rubro7Cliente { get; set; }
        public string? Rubro8Cliente { get; set; }
        public string? Rubro9Cliente { get; set; }
        public string? Rubro10Cliente { get; set; }
        public string UsarPreciosCorp { get; set; } = null!;
        public string UsarExencimpCorp { get; set; } = null!;
        public string? DiasDeCobro { get; set; }
        public string AjusteFechaCobro { get; set; } = null!;
        public string? Gln { get; set; }
        public string? Ubicacion { get; set; }
        public string ClaseDocumento { get; set; } = null!;
        public string Local { get; set; } = null!;
        public string? TipoContribuyente { get; set; }
        public string? Rubro11Cliente { get; set; }
        public string? Rubro12Cliente { get; set; }
        public string? Rubro13Cliente { get; set; }
        public string? Rubro14Cliente { get; set; }
        public string? Rubro15Cliente { get; set; }
        public string? Rubro16Cliente { get; set; }
        public string? Rubro17Cliente { get; set; }
        public string? Rubro18Cliente { get; set; }
        public string? Rubro19Cliente { get; set; }
        public string? Rubro20Cliente { get; set; }
        public string? ModeloRetencion { get; set; }
        public string AceptaDocElectronico { get; set; } = null!;
        public string ConfirmaDocElectronico { get; set; } = null!;
        public string? EmailDocElectronico { get; set; }
        public string? EmailPedEdi { get; set; }
        public string AceptaDocEdi { get; set; } = null!;
        public string NotificarErrorEdi { get; set; } = null!;
        public string? EmailErrorPedEdi { get; set; }
        public string? CodigoImpuesto { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public string? RegimenTrib { get; set; }
        public string Moroso { get; set; } = null!;
        public string ModifNombEnFac { get; set; } = null!;
        public decimal SaldoTrans { get; set; }
        public decimal SaldoTransLocal { get; set; }
        public decimal SaldoTransDolar { get; set; }
        public string PermiteDocGp { get; set; } = null!;
        public string ParticipaFlujocaja { get; set; } = null!;
        public string? Curp { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? UsuarioUltMod { get; set; }
        public DateTime? FchHoraUltMod { get; set; }
        public string? EmailDocElectronicoCopia { get; set; }
        public string DetallarKits { get; set; } = null!;
        public string? XsltPersonalizado { get; set; }
        public string? NombreAddenda { get; set; }
        public decimal? GeoLatitud { get; set; }
        public decimal? GeoLongitud { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? DivisionGeografica3 { get; set; }
        public string? DivisionGeografica4 { get; set; }
        public string? OtrasSenas { get; set; }
        public string? Subtipodoc { get; set; }
        public string? UTipoReceptor { get; set; }
        public string? ApiRecepcionDe { get; set; }
        public string? UsaApiRecepcion { get; set; }
        public string? UserApiRecepcion { get; set; }
        public string? PassApiRecepcion { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public decimal? PorcTarifa { get; set; }
        public string? TipificacionCliente { get; set; }
        public string? AfectacionIva { get; set; }
        public string EsExtranjero { get; set; } = null!;
        public string? ItemHacienda { get; set; }
        public string? XsltPersonalizadoCredito { get; set; }
        public string? TipoGenerar { get; set; }
        public string? TipoPersoneria { get; set; }
        public string? UsoCfdi { get; set; }
        public string? MetodoPago { get; set; }
        public string? BancoNacion { get; set; }
        public string EsAgentePercepcion { get; set; } = null!;
        public string EsBuenContribuyente { get; set; } = null!;

        public virtual CategoriaCliente2 CategoriaClienteNavigation { get; set; } = null!;
        public virtual Cliente2? CliCorporacAsocNavigation { get; set; }
        public virtual Cobrador2 CobradorNavigation { get; set; } = null!;
        public virtual Impuesto2? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago2 CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit2 ContribuyenteNavigation { get; set; } = null!;
        public virtual DetalleDireccion2? DetalleDireccionNavigation { get; set; }
        public virtual ItemsHaciendum2? ItemHaciendaNavigation { get; set; }
        public virtual MetodoPago2? MetodoPagoNavigation { get; set; }
        public virtual ModeloRetencion2? ModeloRetencionNavigation { get; set; }
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual NivelPrecio2 NivelPrecio2 { get; set; } = null!;
        public virtual Pai2 PaisNavigation { get; set; } = null!;
        public virtual Rutum2 RutaNavigation { get; set; } = null!;
        public virtual TipoTarifaIva2? Tipo { get; set; }
        public virtual TipoImpuesto2? TipoImpuestoNavigation { get; set; }
        public virtual TipoTarjetum2? TipoTarjetaNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Vendedor2? VendedorNavigation { get; set; }
        public virtual Zona2 ZonaNavigation { get; set; } = null!;
        public virtual ICollection<AutorVentum2> AutorVentum2s { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2CliDocCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2CliDocDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2CliReporteCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2CliReporteDebitoNavigations { get; set; }
        public virtual ICollection<ClienteRetencion2> ClienteRetencion2s { get; set; }
        public virtual ICollection<ClienteVendedor2> ClienteVendedor2s { get; set; }
        public virtual ICollection<Concepto2> Concepto2s { get; set; }
        public virtual ICollection<ContactoCliente2> ContactoCliente2s { get; set; }
        public virtual ICollection<ContrarecibosCc2> ContrarecibosCc2s { get; set; }
        public virtual ICollection<Despacho2> Despacho2s { get; set; }
        public virtual ICollection<DireccEmbarque2> DireccEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2ClienteNavigations { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2ClienteOrigenNavigations { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2ClienteReporteNavigations { get; set; }
        public virtual ICollection<ExcepcionD1042> ExcepcionD1042s { get; set; }
        public virtual ICollection<Factura2> Factura2ClienteCorporacNavigations { get; set; }
        public virtual ICollection<Factura2> Factura2ClienteDireccionNavigations { get; set; }
        public virtual ICollection<Factura2> Factura2ClienteNavigations { get; set; }
        public virtual ICollection<Factura2> Factura2ClienteOrigenNavigations { get; set; }
        public virtual ICollection<FacturaAduana2> FacturaAduana2s { get; set; }
        public virtual ICollection<Cliente2> InverseCliCorporacAsocNavigation { get; set; }
        public virtual ICollection<OpOperDetProd2> OpOperDetProd2s { get; set; }
        public virtual ICollection<OrdenCliente2> OrdenCliente2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2ClienteCorporacNavigations { get; set; }
        public virtual ICollection<Pedido2> Pedido2ClienteDireccionNavigations { get; set; }
        public virtual ICollection<Pedido2> Pedido2ClienteNavigations { get; set; }
        public virtual ICollection<Pedido2> Pedido2ClienteOrigenNavigations { get; set; }
        public virtual ICollection<ReglaDescuento2> ReglaDescuento2s { get; set; }
        public virtual ICollection<SaldoCliente2> SaldoCliente2s { get; set; }
    }
}
