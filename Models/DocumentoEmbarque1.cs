using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DocumentoEmbarque1
    {
        public DocumentoEmbarque1()
        {
            DetDocumentoEmbarque1s = new HashSet<DetDocumentoEmbarque1>();
            DetDocumentoOrden1s = new HashSet<DetDocumentoOrden1>();
            FiadoresDocCo1s = new HashSet<FiadoresDocCo1>();
            GarantiasDocCo1s = new HashSet<GarantiasDocCo1>();
            ParcialidadesCo1s = new HashSet<ParcialidadesCo1>();
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
        public string? Incoterms { get; set; }
        public string? FormaPago { get; set; }
        public string? TipoOperacion { get; set; }
        public string? Cufe { get; set; }
        public string? Codigoqr { get; set; }

        public virtual ClasifBienesServAdq1? ClasificacionNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual DivisionGeografica21? DivisionGeografica21 { get; set; }
        public virtual ModalidadServicio1? ModalidadServicioNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual TiposRentum1? TipoRentaNavigation { get; set; }
        public virtual TiposDetraccione1? TiposDetraccione1 { get; set; }
        public virtual ICollection<DetDocumentoEmbarque1> DetDocumentoEmbarque1s { get; set; }
        public virtual ICollection<DetDocumentoOrden1> DetDocumentoOrden1s { get; set; }
        public virtual ICollection<FiadoresDocCo1> FiadoresDocCo1s { get; set; }
        public virtual ICollection<GarantiasDocCo1> GarantiasDocCo1s { get; set; }
        public virtual ICollection<ParcialidadesCo1> ParcialidadesCo1s { get; set; }
    }
}
