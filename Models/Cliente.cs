using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            AutorVenta = new HashSet<AutorVentum>();
            AuxiliarCcCliDocCreditNavigations = new HashSet<AuxiliarCc>();
            AuxiliarCcCliDocDebitoNavigations = new HashSet<AuxiliarCc>();
            AuxiliarCcCliReporteCreditNavigations = new HashSet<AuxiliarCc>();
            AuxiliarCcCliReporteDebitoNavigations = new HashSet<AuxiliarCc>();
            ClienteRetencions = new HashSet<ClienteRetencion>();
            ClienteVendedors = new HashSet<ClienteVendedor>();
            Conceptos = new HashSet<Concepto>();
            ContactoClientes = new HashSet<ContactoCliente>();
            ContrarecibosCcs = new HashSet<ContrarecibosCc>();
            CsSeries = new HashSet<CsSerie>();
            Despachos = new HashSet<Despacho>();
            DireccEmbarques = new HashSet<DireccEmbarque>();
            DocumentosCcClienteNavigations = new HashSet<DocumentosCc>();
            DocumentosCcClienteOrigenNavigations = new HashSet<DocumentosCc>();
            DocumentosCcClienteReporteNavigations = new HashSet<DocumentosCc>();
            EstrucClientes = new HashSet<EstrucCliente>();
            ExcepcionD104s = new HashSet<ExcepcionD104>();
            FacturaAduanas = new HashSet<FacturaAduana>();
            FacturaClienteCorporacNavigations = new HashSet<Factura>();
            FacturaClienteDireccionNavigations = new HashSet<Factura>();
            FacturaClienteNavigations = new HashSet<Factura>();
            FacturaClienteOrigenNavigations = new HashSet<Factura>();
            InverseCliCorporacAsocNavigation = new HashSet<Cliente>();
            OpOperDetProds = new HashSet<OpOperDetProd>();
            OrdenClientes = new HashSet<OrdenCliente>();
            PedidoClienteCorporacNavigations = new HashSet<Pedido>();
            PedidoClienteDireccionNavigations = new HashSet<Pedido>();
            PedidoClienteNavigations = new HashSet<Pedido>();
            PedidoClienteOrigenNavigations = new HashSet<Pedido>();
            ReglaDescuentos = new HashSet<ReglaDescuento>();
            SaldoClientes = new HashSet<SaldoCliente>();
        }

        public string Cliente1 { get; set; } = null!;
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

        public virtual CategoriaCliente CategoriaClienteNavigation { get; set; } = null!;
        public virtual Cliente? CliCorporacAsocNavigation { get; set; }
        public virtual Cobrador CobradorNavigation { get; set; } = null!;
        public virtual Impuesto? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit ContribuyenteNavigation { get; set; } = null!;
        public virtual DetalleDireccion? DetalleDireccionNavigation { get; set; }
        public virtual ItemsHaciendum? ItemHaciendaNavigation { get; set; }
        public virtual MetodoPago? MetodoPagoNavigation { get; set; }
        public virtual ModeloRetencion? ModeloRetencionNavigation { get; set; }
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual NivelPrecio NivelPrecioNavigation { get; set; } = null!;
        public virtual Pai PaisNavigation { get; set; } = null!;
        public virtual Rutum RutaNavigation { get; set; } = null!;
        public virtual TipoTarifaIva? Tipo { get; set; }
        public virtual TipoImpuesto? TipoImpuestoNavigation { get; set; }
        public virtual TipoTarjetum? TipoTarjetaNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Vendedor? VendedorNavigation { get; set; }
        public virtual Zona ZonaNavigation { get; set; } = null!;
        public virtual ICollection<AutorVentum> AutorVenta { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcCliDocCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcCliDocDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcCliReporteCreditNavigations { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcCliReporteDebitoNavigations { get; set; }
        public virtual ICollection<ClienteRetencion> ClienteRetencions { get; set; }
        public virtual ICollection<ClienteVendedor> ClienteVendedors { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
        public virtual ICollection<ContactoCliente> ContactoClientes { get; set; }
        public virtual ICollection<ContrarecibosCc> ContrarecibosCcs { get; set; }
        public virtual ICollection<CsSerie> CsSeries { get; set; }
        public virtual ICollection<Despacho> Despachos { get; set; }
        public virtual ICollection<DireccEmbarque> DireccEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcClienteNavigations { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcClienteOrigenNavigations { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcClienteReporteNavigations { get; set; }
        public virtual ICollection<EstrucCliente> EstrucClientes { get; set; }
        public virtual ICollection<ExcepcionD104> ExcepcionD104s { get; set; }
        public virtual ICollection<FacturaAduana> FacturaAduanas { get; set; }
        public virtual ICollection<Factura> FacturaClienteCorporacNavigations { get; set; }
        public virtual ICollection<Factura> FacturaClienteDireccionNavigations { get; set; }
        public virtual ICollection<Factura> FacturaClienteNavigations { get; set; }
        public virtual ICollection<Factura> FacturaClienteOrigenNavigations { get; set; }
        public virtual ICollection<Cliente> InverseCliCorporacAsocNavigation { get; set; }
        public virtual ICollection<OpOperDetProd> OpOperDetProds { get; set; }
        public virtual ICollection<OrdenCliente> OrdenClientes { get; set; }
        public virtual ICollection<Pedido> PedidoClienteCorporacNavigations { get; set; }
        public virtual ICollection<Pedido> PedidoClienteDireccionNavigations { get; set; }
        public virtual ICollection<Pedido> PedidoClienteNavigations { get; set; }
        public virtual ICollection<Pedido> PedidoClienteOrigenNavigations { get; set; }
        public virtual ICollection<ReglaDescuento> ReglaDescuentos { get; set; }
        public virtual ICollection<SaldoCliente> SaldoClientes { get; set; }
    }
}
