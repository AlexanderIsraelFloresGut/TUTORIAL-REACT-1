using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentosCc1
    {
        public DocumentosCc1()
        {
            AnticipoMarcaFact1s = new HashSet<AnticipoMarcaFact1>();
            AuxiliarCc1DocumentosCc1Navigations = new HashSet<AuxiliarCc1>();
            AuxiliarCc1DocumentosCc1s = new HashSet<AuxiliarCc1>();
            DetTiposervicioCc1s = new HashSet<DetTiposervicioCc1>();
            DiferidoDocCc1s = new HashSet<DiferidoDocCc1>();
            DocumentoAnticipo1s = new HashSet<DocumentoAnticipo1>();
            DocumentoAsociado1DocumentosCc1Navigations = new HashSet<DocumentoAsociado1>();
            DocumentoAsociado1DocumentosCc1s = new HashSet<DocumentoAsociado1>();
            Factura1s = new HashSet<Factura1>();
            FacturaDocCc1s = new HashSet<FacturaDocCc1>();
            FiadoresDocCc1s = new HashSet<FiadoresDocCc1>();
            GarantiasDocCc1s = new HashSet<GarantiasDocCc1>();
            ParcialidadesCc1s = new HashSet<ParcialidadesCc1>();
            RetencionesDocCc1s = new HashSet<RetencionesDocCc1>();
            TextosDocsCc1s = new HashSet<TextosDocsCc1>();
        }

        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Contrarecibo { get; set; }
        public string Aplicacion { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal MontoCliente { get; set; }
        public decimal SaldoCliente { get; set; }
        public decimal TipoCambioMoneda { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public decimal TipoCambioClient { get; set; }
        public decimal TipoCambActLoc { get; set; }
        public decimal TipoCambActDol { get; set; }
        public decimal TipoCambActCli { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal Rubro1 { get; set; }
        public decimal Rubro2 { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal SaldoRetencion { get; set; }
        public string Dependiente { get; set; } = null!;
        public DateTime FechaUltCredito { get; set; }
        public string CargadoDeFact { get; set; } = null!;
        public string Aprobado { get; set; } = null!;
        public string? Asiento { get; set; }
        public string AsientoPendiente { get; set; } = null!;
        public DateTime FechaUltMod { get; set; }
        public string? Notas { get; set; }
        public string ClaseDocumento { get; set; } = null!;
        public DateTime FechaVence { get; set; }
        public short NumParcialidades { get; set; }
        public DateTime? FechaRevision { get; set; }
        public string? Cobrador { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? CtaBancaria { get; set; }
        public string? Vendedor { get; set; }
        public string ClienteReporte { get; set; } = null!;
        public string ClienteOrigen { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public short? Subtipo { get; set; }
        public decimal PorcIntcte { get; set; }
        public string? Contrato { get; set; }
        public string? TipoDocOrigen { get; set; }
        public string? DocDocOrigen { get; set; }
        public DateTime? FechaAnul { get; set; }
        public string? AudUsuarioAnul { get; set; }
        public DateTime? AudFechaAnul { get; set; }
        public decimal? NumDocCb { get; set; }
        public DateTime? FechaCobro { get; set; }
        public string? AuditoriaCobro { get; set; }
        public DateTime? FechaSeguimiento { get; set; }
        public string? ObservacionesCobro { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? Anulado { get; set; }
        public string? CodigoImpuesto { get; set; }
        public string? Pais { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public string DependienteGp { get; set; } = null!;
        public decimal SaldoTrans { get; set; }
        public decimal SaldoTransLocal { get; set; }
        public decimal SaldoTransDolar { get; set; }
        public DateTime? FechaProyectada { get; set; }
        public decimal? PorcRecuperacion { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public decimal SaldoTransCli { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string Facturado { get; set; } = null!;
        public string GeneraDocFe { get; set; } = null!;
        public string? TasaImpositiva { get; set; }
        public decimal? TasaImpositivaPorc { get; set; }
        public string? TasaCree1 { get; set; }
        public decimal? TasaCree1Porc { get; set; }
        public string? TasaCree2 { get; set; }
        public decimal? TasaCree2Porc { get; set; }
        public decimal? TasaGanOcasionalPorc { get; set; }
        public string? EntidadFinanciera { get; set; }
        public string? ContratoAc { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CuentaOrigen { get; set; }
        public string? UsoCfdi { get; set; }
        public string? UClaveUnidad { get; set; }
        public string? UClaveProdServ { get; set; }
        public string? FormaPago { get; set; }
        public string? UTipoRelacion { get; set; }
        public string? ClaveReferenciaDe { get; set; }
        public DateTime? FechaReferenciaDe { get; set; }
        public string? JustiDevHaciend { get; set; }
        public string? TipoOperacion { get; set; }
        public string? UClavePsPub { get; set; }
        public string? Incoterms { get; set; }
        public string? Consecutivo { get; set; }
        public string? ClaveDe { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public string? ActividadComercial { get; set; }
        public string? Cancelacion { get; set; }
        public string? EstadoCancelacion { get; set; }
        public string? TieneRelacionados { get; set; }
        public string? ItemHacienda { get; set; }
        public string? Prefijo { get; set; }
        public DateTime? FechaInicioResolucion { get; set; }
        public DateTime? FechaFinalResolucion { get; set; }
        public string? ClaveTecnica { get; set; }
        public int? MatriculaMercantil { get; set; }
        public string? EsFacturaReemplazo { get; set; }
        public string? FacturaOriginalReemplazo { get; set; }
        public string? TipoReferenciaDe { get; set; }
        public string? ConsecutivoFtc { get; set; }
        public string? NumeroFtc { get; set; }
        public string? NitTransportador { get; set; }
        public string? CodigoReferenciaDe { get; set; }
        public string? NcfModificado { get; set; }
        public string? NumOcExenta { get; set; }
        public string? NumConsRegExo { get; set; }
        public string? NumIrsedeAgrGan { get; set; }
        public string? UAdWmTipoNc { get; set; }
        public string? TipoPago { get; set; }
        public string? MetodoPago { get; set; }
        public string? TipoFactura { get; set; }
        public string? TipoDescuento { get; set; }
        public string? TipoNc { get; set; }
        public string? TipoNd { get; set; }
        public string? NumeroOrden { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoDetrac { get; set; }
        public string? ActDetrac { get; set; }
        public decimal? PorcDetrac { get; set; }
        public string? GuuidOriginal { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }
        public string? Gtin { get; set; }
        public string? TieneComplemento { get; set; }
        public decimal ImpuestoBolsa { get; set; }
        public string? GenerarCfdiTraslado { get; set; }
        public string ProcesoSemt { get; set; } = null!;
        public string? HistorialSemt { get; set; }
        public string? IncluirDocCfdi { get; set; }
        public string? TipoRelacion { get; set; }
        public string? Tipocadpago { get; set; }
        public string? Certpago { get; set; }
        public string? Cadpago { get; set; }
        public string? Sellopago { get; set; }
        public string? MotivoCancelacion { get; set; }
        public string? FolioFiscalSustituto { get; set; }
        public string? Cufe { get; set; }
        public string? Codigoqr { get; set; }

        public virtual Usuario2? AudUsuarioAnulNavigation { get; set; }
        public virtual Cliente1 ClienteNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteOrigenNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteReporteNavigation { get; set; } = null!;
        public virtual Cobrador1? CobradorNavigation { get; set; }
        public virtual Impuesto1? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual CuentaBancarium1? CtaBancariaNavigation { get; set; }
        public virtual DivisionGeografica21? DivisionGeografica21 { get; set; }
        public virtual ItemsHaciendum1? ItemHaciendaNavigation { get; set; }
        public virtual MetodoPago1? MetodoPagoNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCc1? SubtipoDocCc1 { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual TipoDescuento1? TipoDescuentoNavigation { get; set; }
        public virtual TipoFactura1? TipoFacturaNavigation { get; set; }
        public virtual TipoImpuesto1? TipoImpuestoNavigation { get; set; }
        public virtual TipoNc1? TipoNcNavigation { get; set; }
        public virtual TipoNd1? TipoNdNavigation { get; set; }
        public virtual NaturalezaOperacion? TipoOperacionNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual TipoRelacion? TipoRelacionNavigation { get; set; }
        public virtual TiposDetraccione1? TiposDetraccione1 { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual Vendedor1? VendedorNavigation { get; set; }
        public virtual ICollection<AnticipoMarcaFact1> AnticipoMarcaFact1s { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1DocumentosCc1Navigations { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1DocumentosCc1s { get; set; }
        public virtual ICollection<DetTiposervicioCc1> DetTiposervicioCc1s { get; set; }
        public virtual ICollection<DiferidoDocCc1> DiferidoDocCc1s { get; set; }
        public virtual ICollection<DocumentoAnticipo1> DocumentoAnticipo1s { get; set; }
        public virtual ICollection<DocumentoAsociado1> DocumentoAsociado1DocumentosCc1Navigations { get; set; }
        public virtual ICollection<DocumentoAsociado1> DocumentoAsociado1DocumentosCc1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<FacturaDocCc1> FacturaDocCc1s { get; set; }
        public virtual ICollection<FiadoresDocCc1> FiadoresDocCc1s { get; set; }
        public virtual ICollection<GarantiasDocCc1> GarantiasDocCc1s { get; set; }
        public virtual ICollection<ParcialidadesCc1> ParcialidadesCc1s { get; set; }
        public virtual ICollection<RetencionesDocCc1> RetencionesDocCc1s { get; set; }
        public virtual ICollection<TextosDocsCc1> TextosDocsCc1s { get; set; }
    }
}
