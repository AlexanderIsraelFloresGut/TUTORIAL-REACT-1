using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cliente1
    {
        public Cliente1()
        {
            AutorVentum1s = new HashSet<AutorVentum1>();
            AuxiliarCc1CliDocCreditNavigations = new HashSet<AuxiliarCc1>();
            AuxiliarCc1CliDocDebitoNavigations = new HashSet<AuxiliarCc1>();
            AuxiliarCc1CliReporteCreditNavigations = new HashSet<AuxiliarCc1>();
            AuxiliarCc1CliReporteDebitoNavigations = new HashSet<AuxiliarCc1>();
            ClienteRetencion1s = new HashSet<ClienteRetencion1>();
            ClienteVendedor1s = new HashSet<ClienteVendedor1>();
            Concepto1s = new HashSet<Concepto1>();
            ContactoCliente1s = new HashSet<ContactoCliente1>();
            ContrarecibosCc1s = new HashSet<ContrarecibosCc1>();
            Despacho1s = new HashSet<Despacho1>();
            DireccEmbarque1s = new HashSet<DireccEmbarque1>();
            DocumentosCc1ClienteNavigations = new HashSet<DocumentosCc1>();
            DocumentosCc1ClienteOrigenNavigations = new HashSet<DocumentosCc1>();
            DocumentosCc1ClienteReporteNavigations = new HashSet<DocumentosCc1>();
            EstrucCliente1s = new HashSet<EstrucCliente1>();
            ExcepcionD1041s = new HashSet<ExcepcionD1041>();
            Factura1ClienteCorporacNavigations = new HashSet<Factura1>();
            Factura1ClienteDireccionNavigations = new HashSet<Factura1>();
            Factura1ClienteNavigations = new HashSet<Factura1>();
            Factura1ClienteOrigenNavigations = new HashSet<Factura1>();
            FacturaAduana1s = new HashSet<FacturaAduana1>();
            InverseCliCorporacAsocNavigation = new HashSet<Cliente1>();
            OpOperDetProd1s = new HashSet<OpOperDetProd1>();
            OrdenCliente1s = new HashSet<OrdenCliente1>();
            Pedido1ClienteCorporacNavigations = new HashSet<Pedido1>();
            Pedido1ClienteDireccionNavigations = new HashSet<Pedido1>();
            Pedido1ClienteNavigations = new HashSet<Pedido1>();
            Pedido1ClienteOrigenNavigations = new HashSet<Pedido1>();
            ReglaDescuento1s = new HashSet<ReglaDescuento1>();
            SaldoCliente1s = new HashSet<SaldoCliente1>();
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
        public string? UUdf { get; set; }
        public string? ULunes { get; set; }
        public string? UMartes { get; set; }
        public string? UMiercoles { get; set; }
        public string? UJueves { get; set; }
        public string? UViernes { get; set; }
        public string? USabado { get; set; }
        public string? ULatitud { get; set; }
        public string? ULongitud { get; set; }
        public decimal? UFrecuencia { get; set; }
        public string? UPeriodicidad { get; set; }
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
        public string SujetoPorceSunat { get; set; } = null!;
        public string PdbExportadores { get; set; } = null!;

        public virtual CategoriaCliente1 CategoriaClienteNavigation { get; set; } = null!;
        public virtual Cliente1? CliCorporacAsocNavigation { get; set; }
        public virtual Cobrador1 CobradorNavigation { get; set; } = null!;
        public virtual Impuesto1? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit1 ContribuyenteNavigation { get; set; } = null!;
        public virtual DetalleDireccion1? DetalleDireccionNavigation { get; set; }
        public virtual ItemsHaciendum1? ItemHaciendaNavigation { get; set; }
        public virtual MetodoPago1? MetodoPagoNavigation { get; set; }
        public virtual ModeloRetencion1? ModeloRetencionNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual NivelPrecio1 NivelPrecio1 { get; set; } = null!;
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual Rutum1 RutaNavigation { get; set; } = null!;
        public virtual TipoTarifaIva1? Tipo { get; set; }
        public virtual TipoImpuesto1? TipoImpuestoNavigation { get; set; }
        public virtual TipoTarjetum1? TipoTarjetaNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Vendedor1? VendedorNavigation { get; set; }
        public virtual Zona1 ZonaNavigation { get; set; } = null!;
        public virtual ICollection<AutorVentum1> AutorVentum1s { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1CliDocCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1CliDocDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1CliReporteCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1CliReporteDebitoNavigations { get; set; }
        public virtual ICollection<ClienteRetencion1> ClienteRetencion1s { get; set; }
        public virtual ICollection<ClienteVendedor1> ClienteVendedor1s { get; set; }
        public virtual ICollection<Concepto1> Concepto1s { get; set; }
        public virtual ICollection<ContactoCliente1> ContactoCliente1s { get; set; }
        public virtual ICollection<ContrarecibosCc1> ContrarecibosCc1s { get; set; }
        public virtual ICollection<Despacho1> Despacho1s { get; set; }
        public virtual ICollection<DireccEmbarque1> DireccEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1ClienteNavigations { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1ClienteOrigenNavigations { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1ClienteReporteNavigations { get; set; }
        public virtual ICollection<EstrucCliente1> EstrucCliente1s { get; set; }
        public virtual ICollection<ExcepcionD1041> ExcepcionD1041s { get; set; }
        public virtual ICollection<Factura1> Factura1ClienteCorporacNavigations { get; set; }
        public virtual ICollection<Factura1> Factura1ClienteDireccionNavigations { get; set; }
        public virtual ICollection<Factura1> Factura1ClienteNavigations { get; set; }
        public virtual ICollection<Factura1> Factura1ClienteOrigenNavigations { get; set; }
        public virtual ICollection<FacturaAduana1> FacturaAduana1s { get; set; }
        public virtual ICollection<Cliente1> InverseCliCorporacAsocNavigation { get; set; }
        public virtual ICollection<OpOperDetProd1> OpOperDetProd1s { get; set; }
        public virtual ICollection<OrdenCliente1> OrdenCliente1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1ClienteCorporacNavigations { get; set; }
        public virtual ICollection<Pedido1> Pedido1ClienteDireccionNavigations { get; set; }
        public virtual ICollection<Pedido1> Pedido1ClienteNavigations { get; set; }
        public virtual ICollection<Pedido1> Pedido1ClienteOrigenNavigations { get; set; }
        public virtual ICollection<ReglaDescuento1> ReglaDescuento1s { get; set; }
        public virtual ICollection<SaldoCliente1> SaldoCliente1s { get; set; }
    }
}
