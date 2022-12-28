using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentosCp1
    {
        public DocumentosCp1()
        {
            AuxiliarCp1DocumentosCp1Navigations = new HashSet<AuxiliarCp1>();
            AuxiliarCp1DocumentosCp1s = new HashSet<AuxiliarCp1>();
            CpDetRetencionPar1s = new HashSet<CpDetRetencionPar1>();
            DetTiposervicioCp1s = new HashSet<DetTiposervicioCp1>();
            DetalleRetencion1s = new HashSet<DetalleRetencion1>();
            EmbarqueDocCp1s = new HashSet<EmbarqueDocCp1>();
            FiadoresDocCp1s = new HashSet<FiadoresDocCp1>();
            GarantiasDocCp1s = new HashSet<GarantiasDocCp1>();
            ParcialidadesCp1s = new HashSet<ParcialidadesCp1>();
            RecepcionDetrac1DocumentosCp1Navigations = new HashSet<RecepcionDetrac1>();
            RecepcionDetrac1DocumentosCp1s = new HashSet<RecepcionDetrac1>();
        }

        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string EmbarqueAprobado { get; set; } = null!;
        public decimal? TipoCambLiqLoc { get; set; }
        public decimal? TipoCambLiqDol { get; set; }
        public DateTime FechaDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string? TipoProrrateo { get; set; }
        public string? Etiqueta { get; set; }
        public string TipoEmbarque { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoLocal { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public decimal SaldoDolar { get; set; }
        public decimal TipoCambioMoneda { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public DateTime FechaUltCredito { get; set; }
        public string ChequeImpreso { get; set; } = null!;
        public string Aprobado { get; set; } = null!;
        public string Seleccionado { get; set; } = null!;
        public string Congelado { get; set; } = null!;
        public decimal MontoProv { get; set; }
        public decimal SaldoProv { get; set; }
        public decimal TipoCambioProv { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal Rubro1 { get; set; }
        public decimal Rubro2 { get; set; }
        public DateTime FechaUltMod { get; set; }
        public decimal MontoRetencion { get; set; }
        public decimal SaldoRetencion { get; set; }
        public string Dependiente { get; set; } = null!;
        public string? Asiento { get; set; }
        public string AsientoPendiente { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal TipoCambActLoc { get; set; }
        public decimal TipoCambActDol { get; set; }
        public decimal TipoCambActProv { get; set; }
        public string DocumentoEmbarque { get; set; } = null!;
        public DateTime? FechaRevision { get; set; }
        public string? LiquidacCompra { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string? ChequeCuenta { get; set; }
        public string? Contrarecibo { get; set; }
        public short? Subtipo { get; set; }
        public DateTime FechaVence { get; set; }
        public DateTime? FechaAnul { get; set; }
        public string? AudUsuarioAnul { get; set; }
        public DateTime? AudFechaAnul { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public decimal? MontoPago { get; set; }
        public string? Usuario { get; set; }
        public string? CuentaBanco { get; set; }
        public decimal? TipoCambio { get; set; }
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
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string? EstadoEnvio { get; set; }
        public string? ConceptoMe { get; set; }
        public string ParticipaIetu { get; set; } = null!;
        public string ClaseDocumento { get; set; } = null!;
        public decimal PorcIntcte { get; set; }
        public string? Contrato { get; set; }
        public short NumParcialidades { get; set; }
        public string? TasaImpositiva { get; set; }
        public decimal? TasaImpositivaPorc { get; set; }
        public string? TasaCree1 { get; set; }
        public decimal? TasaCree1Porc { get; set; }
        public string? TasaCree2 { get; set; }
        public decimal? TasaCree2Porc { get; set; }
        public decimal? TasaGanOcasionalPorc { get; set; }
        public string GeneraDocFe { get; set; } = null!;
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UCashp { get; set; }
        public DateTime? FechaCai { get; set; }
        public string? Cai { get; set; }
        public string? TipoImpuesto1 { get; set; }
        public string? TipoTarifa1 { get; set; }
        public string? TipoImpuesto2 { get; set; }
        public string? TipoTarifa2 { get; set; }
        public string? ConsecutivoDoc { get; set; }
        public string? ClaveDe { get; set; }
        public string? TipoAfectacionIva { get; set; }
        public string? TipoImpuestoAfectacion { get; set; }
        public string? TipoTarifaAfectacion { get; set; }
        public decimal? PorcAfectacionIva { get; set; }
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public string? ActividadComercial { get; set; }
        public string? ItemHacienda { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }
        public string? NcfModificado { get; set; }
        public string? DestinoItbis { get; set; }
        public string? TipoDocReferencia { get; set; }
        public string? ClaveReferencia { get; set; }
        public DateTime? FechaEmisionReferencia { get; set; }
        public string? CodigoReferencia { get; set; }
        public string? RazonReferencia { get; set; }
        public string? TipoPago { get; set; }
        public string? MetodoPago { get; set; }
        public decimal? MontoReferencia { get; set; }
        public string GeneDocDetrac { get; set; } = null!;
        public string? TipoDetrac { get; set; }
        public string? ActDetrac { get; set; }
        public decimal? PorcDetrac { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? AdValorem { get; set; }
        public decimal? ValorAduana { get; set; }
        public string? Aduana { get; set; }
        public decimal? DeducCostoEnajena { get; set; }
        public decimal? RentaNeta { get; set; }
        public string? TipoRenta { get; set; }
        public string? ModalidadServicio { get; set; }
        public int? AnioDua { get; set; }
        public string? Clasificacion { get; set; }
        public decimal? MontoNoGravado { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }
        public decimal ImpuestoBolsa { get; set; }
        public string ProcesoSemt { get; set; } = null!;
        public string? HistorialSemt { get; set; }
        public string? TipoOperacion { get; set; }
        public string? FormaPago { get; set; }
        public string? Incoterms { get; set; }
        public string? Cufe { get; set; }
        public string? Codigoqr { get; set; }
        public string? Rechazado { get; set; }

        public virtual Aduana1? AduanaNavigation { get; set; }
        public virtual CuentaBancarium1? ChequeCuentaNavigation { get; set; }
        public virtual ClasifBienesServAdq1? ClasificacionNavigation { get; set; }
        public virtual Impuesto1? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual Contrarecibo1? ContrareciboNavigation { get; set; }
        public virtual CuentaBancarium1? CuentaBancoNavigation { get; set; }
        public virtual DivisionGeografica21? DivisionGeografica21 { get; set; }
        public virtual ItemsHaciendum1? ItemHaciendaNavigation { get; set; }
        public virtual LiquidacCompra1? LiquidacCompraNavigation { get; set; }
        public virtual MetodoPago1? MetodoPagoNavigation { get; set; }
        public virtual ModalidadServicio1? ModalidadServicioNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
        public virtual SubtipoDocCp1? SubtipoDocCp1 { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual NaturalezaOperacion? TipoOperacionNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual TiposRentum1? TipoRentaNavigation { get; set; }
        public virtual TiposDetraccione1? TiposDetraccione1 { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1DocumentosCp1Navigations { get; set; }
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1DocumentosCp1s { get; set; }
        public virtual ICollection<CpDetRetencionPar1> CpDetRetencionPar1s { get; set; }
        public virtual ICollection<DetTiposervicioCp1> DetTiposervicioCp1s { get; set; }
        public virtual ICollection<DetalleRetencion1> DetalleRetencion1s { get; set; }
        public virtual ICollection<EmbarqueDocCp1> EmbarqueDocCp1s { get; set; }
        public virtual ICollection<FiadoresDocCp1> FiadoresDocCp1s { get; set; }
        public virtual ICollection<GarantiasDocCp1> GarantiasDocCp1s { get; set; }
        public virtual ICollection<ParcialidadesCp1> ParcialidadesCp1s { get; set; }
        public virtual ICollection<RecepcionDetrac1> RecepcionDetrac1DocumentosCp1Navigations { get; set; }
        public virtual ICollection<RecepcionDetrac1> RecepcionDetrac1DocumentosCp1s { get; set; }
    }
}
