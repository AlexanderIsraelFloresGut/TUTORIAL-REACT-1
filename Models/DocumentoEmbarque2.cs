using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoEmbarque2
    {
        public DocumentoEmbarque2()
        {
            DetDocumentoEmbarque2s = new HashSet<DetDocumentoEmbarque2>();
            DetDocumentoOrden2s = new HashSet<DetDocumentoOrden2>();
            FiadoresDocCo2s = new HashSet<FiadoresDocCo2>();
            GarantiasDocCo2s = new HashSet<GarantiasDocCo2>();
            ParcialidadesCo2s = new HashSet<ParcialidadesCo2>();
        }

        public string Documento { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string ProcesadoCp { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public DateTime FechaDocumento { get; set; }
        public DateTime FechaRige { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal MontoDocumento { get; set; }
        public short Subtipo { get; set; }
        public string? FacturaCp { get; set; }
        public decimal? PorcDescuento { get; set; }
        public decimal? MontoImporte { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal? MontoImpuesto1 { get; set; }
        public decimal? MontoImpuesto2 { get; set; }
        public string? TipoProrrateo { get; set; }
        public decimal? MontoFlete { get; set; }
        public decimal? MontoSeguro { get; set; }
        public decimal? MontoDocumentacion { get; set; }
        public string? Notas { get; set; }
        public string? Pais { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public string? DocumentoFiscal { get; set; }
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
        public string? AsientoFinanciero { get; set; }
        public DateTime? FechaContaFinanciera { get; set; }
        public DateTime? FechaContaFiscal { get; set; }
        public decimal? TipoCambioMoneda { get; set; }
        public decimal? TipoCambioDolar { get; set; }
        public decimal? TipoCambioProv { get; set; }
        public string? MonedaCalculada { get; set; }
        public string? TcModificado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaCai { get; set; }
        public string? Cai { get; set; }
        public string? TipoAfectacionIva { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public decimal? PorcAfectacionIva { get; set; }
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public string? ConsecutivoDoc { get; set; }
        public string? GeneraDocFe { get; set; }
        public string? ClaveDe { get; set; }
        public string? ActividadComercial { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }
        public string? DestinoItbis { get; set; }
        public string? TipoDocReferencia { get; set; }
        public string? ClaveReferencia { get; set; }
        public DateTime? FechaEmisionReferencia { get; set; }
        public string? CodigoReferencia { get; set; }
        public string? RazonReferencia { get; set; }
        public string? TipoPago { get; set; }
        public decimal? MontoReferencia { get; set; }
        public string GeneDocDetrac { get; set; } = null!;
        public string? TipoDetrac { get; set; }
        public string? ActDetrac { get; set; }
        public decimal? PorcDetrac { get; set; }
        public decimal? DeducCostoEnajena { get; set; }
        public decimal? RentaNeta { get; set; }
        public string? TipoRenta { get; set; }
        public string? ModalidadServicio { get; set; }
        public int? AnioDua { get; set; }
        public string? Clasificacion { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual ClasifBienesServAdq2? ClasificacionNavigation { get; set; }
        public virtual CondicionPago2 CondicionPagoNavigation { get; set; } = null!;
        public virtual DivisionGeografica22? DivisionGeografica22 { get; set; }
        public virtual ModalidadServicio2? ModalidadServicioNavigation { get; set; }
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual Proveedor2 ProveedorNavigation { get; set; } = null!;
        public virtual TipoPago2? TipoPagoNavigation { get; set; }
        public virtual TiposRentum2? TipoRentaNavigation { get; set; }
        public virtual TiposDetraccione2? TiposDetraccione2 { get; set; }
        public virtual ICollection<DetDocumentoEmbarque2> DetDocumentoEmbarque2s { get; set; }
        public virtual ICollection<DetDocumentoOrden2> DetDocumentoOrden2s { get; set; }
        public virtual ICollection<FiadoresDocCo2> FiadoresDocCo2s { get; set; }
        public virtual ICollection<GarantiasDocCo2> GarantiasDocCo2s { get; set; }
        public virtual ICollection<ParcialidadesCo2> ParcialidadesCo2s { get; set; }
    }
}
