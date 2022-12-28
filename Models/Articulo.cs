using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            AliasProduccions = new HashSet<AliasProduccion>();
            ArtUndDistribucis = new HashSet<ArtUndDistribuci>();
            ArticuloAlternoAlternoNavigations = new HashSet<ArticuloAlterno>();
            ArticuloAlternoArticuloNavigations = new HashSet<ArticuloAlterno>();
            ArticuloEnsambleArticuloHijoNavigations = new HashSet<ArticuloEnsamble>();
            ArticuloEnsambleArticuloPadreNavigations = new HashSet<ArticuloEnsamble>();
            ArticuloFotos = new HashSet<ArticuloFoto>();
            ArticuloPrecios = new HashSet<ArticuloPrecio>();
            ArticuloProveedors = new HashSet<ArticuloProveedor>();
            BoletaInvFisicos = new HashSet<BoletaInvFisico>();
            BomArticuloDets = new HashSet<BomArticuloDet>();
            BomArticulos = new HashSet<BomArticulo>();
            ClasificAdiArticulos = new HashSet<ClasificAdiArticulo>();
            ClasificacionVenta = new HashSet<ClasificacionVentum>();
            CostoStdDesgls = new HashSet<CostoStdDesgl>();
            CostoUepsPeps = new HashSet<CostoUepsPep>();
            CsOrdenProduccionBcfoods = new HashSet<CsOrdenProduccionBcfood>();
            CsOrdenProduccions = new HashSet<CsOrdenProduccion>();
            CsRecetaLineas = new HashSet<CsRecetaLinea>();
            CsSeries = new HashSet<CsSerie>();
            DespachoDetalles = new HashSet<DespachoDetalle>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            EscalaBonifArticuloBonifNavigations = new HashSet<EscalaBonif>();
            EscalaBonifArticuloNavigations = new HashSet<EscalaBonif>();
            EscalaDctos = new HashSet<EscalaDcto>();
            ExcepcionD104s = new HashSet<ExcepcionD104>();
            ExistenciaBodegas = new HashSet<ExistenciaBodega>();
            ExistenciaCierres = new HashSet<ExistenciaCierre>();
            FacturaLineas = new HashSet<FacturaLinea>();
            GarantiasDocCcs = new HashSet<GarantiasDocCc>();
            GarantiasDocCos = new HashSet<GarantiasDocCo>();
            GarantiasDocCps = new HashSet<GarantiasDocCp>();
            GarantiasDocFas = new HashSet<GarantiasDocFa>();
            GarantiasPedFas = new HashSet<GarantiasPedFa>();
            ImpProcesos = new HashSet<ImpProceso>();
            ImplosionDetalles = new HashSet<ImplosionDetalle>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            LiquidacGastos = new HashSet<LiquidacGasto>();
            Lotes = new HashSet<Lote>();
            OpOperConsumos = new HashSet<OpOperConsumo>();
            OpOperDetProds = new HashSet<OpOperDetProd>();
            OpOperProds = new HashSet<OpOperProd>();
            OrdenCompraLineas = new HashSet<OrdenCompraLinea>();
            OtArticulos = new HashSet<OtArticulo>();
            OtReporteConsumos = new HashSet<OtReporteConsumo>();
            PedidoLineas = new HashSet<PedidoLinea>();
            PedidoSugeridos = new HashSet<PedidoSugerido>();
            PrecioArtProvs = new HashSet<PrecioArtProv>();
            ProcArticulos = new HashSet<ProcArticulo>();
            ReglaDescuentos = new HashSet<ReglaDescuento>();
            RequisicionLineas = new HashSet<RequisicionLinea>();
            SolicitudOcLineas = new HashSet<SolicitudOcLinea>();
            SpPronosticoDetalles = new HashSet<SpPronosticoDetalle>();
            SustitutoMpMatPrimaOrigNavigations = new HashSet<SustitutoMp>();
            SustitutoMpMatSubstitutoNavigations = new HashSet<SustitutoMp>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string Articulo1 { get; set; } = null!;
        public string? PlantillaSerie { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public decimal? FactorConver1 { get; set; }
        public decimal? FactorConver2 { get; set; }
        public decimal? FactorConver3 { get; set; }
        public decimal? FactorConver4 { get; set; }
        public decimal? FactorConver5 { get; set; }
        public decimal? FactorConver6 { get; set; }
        public string Tipo { get; set; } = null!;
        public string OrigenCorp { get; set; } = null!;
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal Volumen { get; set; }
        public short Bultos { get; set; }
        public string ArticuloCuenta { get; set; } = null!;
        public string Impuesto { get; set; } = null!;
        public decimal FactorEmpaque { get; set; }
        public decimal FactorVenta { get; set; }
        public decimal ExistenciaMinima { get; set; }
        public decimal ExistenciaMaxima { get; set; }
        public decimal PuntoDeReorden { get; set; }
        public string CostoFiscal { get; set; } = null!;
        public string CostoComparativo { get; set; } = null!;
        public decimal CostoPromLoc { get; set; }
        public decimal CostoPromDol { get; set; }
        public decimal CostoStdLoc { get; set; }
        public decimal CostoStdDol { get; set; }
        public decimal CostoUltLoc { get; set; }
        public decimal CostoUltDol { get; set; }
        public decimal PrecioBaseLocal { get; set; }
        public decimal PrecioBaseDolar { get; set; }
        public DateTime UltimaSalida { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public DateTime UltimoIngreso { get; set; }
        public DateTime UltimoInventario { get; set; }
        public string ClaseAbc { get; set; } = null!;
        public short FrecuenciaConteo { get; set; }
        public string? CodigoBarrasVent { get; set; }
        public string? CodigoBarrasInvt { get; set; }
        public string Activo { get; set; } = null!;
        public string UsaLotes { get; set; } = null!;
        public string ObligaCuarentena { get; set; } = null!;
        public short MinVidaCompra { get; set; }
        public short MinVidaConsumo { get; set; }
        public short MinVidaVenta { get; set; }
        public short VidaUtilProm { get; set; }
        public short DiasCuarentena { get; set; }
        public string? Proveedor { get; set; }
        public string? ArticuloDelProv { get; set; }
        public decimal OrdenMinima { get; set; }
        public short PlazoReabast { get; set; }
        public decimal LoteMultiplo { get; set; }
        public string? Notas { get; set; }
        public string UtilizadoManufact { get; set; } = null!;
        public string? UsuarioCreacion { get; set; }
        public DateTime? FchHoraCreacion { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FchHoraUltModif { get; set; }
        public string UsaNumerosSerie { get; set; } = null!;
        public string? ModalidadInvFis { get; set; }
        public string? TipoCodBarraDet { get; set; }
        public string? TipoCodBarraAlm { get; set; }
        public string? UsaReglasLocales { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string UnidadEmpaque { get; set; } = null!;
        public string UnidadVenta { get; set; } = null!;
        public string Perecedero { get; set; } = null!;
        public string? Gtin { get; set; }
        public string? Manufacturador { get; set; }
        public string? CodigoRetencion { get; set; }
        public string? RetencionVenta { get; set; }
        public string? RetencionCompra { get; set; }
        public string? ModeloRetencion { get; set; }
        public string? Estilo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string TipoCosto { get; set; } = null!;
        public string? ArticuloEnvase { get; set; }
        public string EsEnvase { get; set; } = null!;
        public string UsaControlEnvase { get; set; } = null!;
        public decimal CostoPromComparativoLoc { get; set; }
        public decimal CostoPromComparativoDolar { get; set; }
        public decimal CostoPromUltimoLoc { get; set; }
        public decimal CostoPromUltimoDol { get; set; }
        public string UtilizadoEnContratos { get; set; } = null!;
        public string ValidaCantFasePy { get; set; } = null!;
        public string ObligaIncluirFasePy { get; set; } = null!;
        public string EsImpuesto { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? USerie { get; set; }
        public decimal CantidadProduccion { get; set; }
        public decimal? Rendimiento { get; set; }
        public string? UWalmart { get; set; }
        public string? UVtaLocal { get; set; }
        public string? UFresco { get; set; }
        public string? UCongelado { get; set; }
        public string? UPresentacion { get; set; }
        public string? UClaveUnidad { get; set; }
        public string? UClaveProdServ { get; set; }
        public string? UClavePsPub { get; set; }
        public string? TipoDocIva { get; set; }
        public string? Nit { get; set; }
        public string CanastaBasica { get; set; } = null!;
        public string EsOtroCargo { get; set; } = null!;
        public string ServicioMedico { get; set; } = null!;
        public string? ItemHacienda { get; set; }
        public string? CodigoHacienda { get; set; }
        public string? ItemHaciendaCompra { get; set; }
        public string Tienda { get; set; } = null!;
        public string SugiereMin { get; set; } = null!;
        public string? TipoExistencia { get; set; }
        public string? CatalogoExistencia { get; set; }
        public string? TipoDetraccionVenta { get; set; }
        public string? CodigoDetraccionVenta { get; set; }
        public string? TipoDetraccionCompra { get; set; }
        public string? CodigoDetraccionCompra { get; set; }
        public string CalcPercep { get; set; } = null!;
        public decimal? PorcPercep { get; set; }

        public virtual ArticuloCuentum ArticuloCuentaNavigation { get; set; } = null!;
        public virtual CatalogoExistencium? CatalogoExistenciaNavigation { get; set; }
        public virtual Clasificacion? Clasificacion1Navigation { get; set; }
        public virtual Clasificacion? Clasificacion2Navigation { get; set; }
        public virtual Clasificacion? Clasificacion3Navigation { get; set; }
        public virtual Clasificacion? Clasificacion4Navigation { get; set; }
        public virtual Clasificacion? Clasificacion5Navigation { get; set; }
        public virtual Clasificacion? Clasificacion6Navigation { get; set; }
        public virtual Retencione? CodigoRetencionNavigation { get; set; }
        public virtual ArticuloColor? ColorNavigation { get; set; }
        public virtual ArticuloEstilo? EstiloNavigation { get; set; }
        public virtual Impuesto ImpuestoNavigation { get; set; } = null!;
        public virtual ItemsHaciendum? ItemHaciendaNavigation { get; set; }
        public virtual ModeloRetencion? ModeloRetencionNavigation { get; set; }
        public virtual Nit? NitNavigation { get; set; }
        public virtual SeriePlantilla? PlantillaSerieNavigation { get; set; }
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual Retencione? RetencionCompraNavigation { get; set; }
        public virtual ArticuloTalla? TallaNavigation { get; set; }
        public virtual TipoExistencium? TipoExistenciaNavigation { get; set; }
        public virtual TiposDetraccione? TiposDetraccione { get; set; }
        public virtual TiposDetraccione? TiposDetraccioneNavigation { get; set; }
        public virtual UnidadDeMedidum UnidadAlmacenNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum UnidadEmpaqueNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum UnidadVentaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ArticuloCompra ArticuloCompra { get; set; } = null!;
        public virtual CostStdBatch CostStdBatch { get; set; } = null!;
        public virtual CsRecetaProduccion CsRecetaProduccion { get; set; } = null!;
        public virtual ICollection<AliasProduccion> AliasProduccions { get; set; }
        public virtual ICollection<ArtUndDistribuci> ArtUndDistribucis { get; set; }
        public virtual ICollection<ArticuloAlterno> ArticuloAlternoAlternoNavigations { get; set; }
        public virtual ICollection<ArticuloAlterno> ArticuloAlternoArticuloNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble> ArticuloEnsambleArticuloHijoNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble> ArticuloEnsambleArticuloPadreNavigations { get; set; }
        public virtual ICollection<ArticuloFoto> ArticuloFotos { get; set; }
        public virtual ICollection<ArticuloPrecio> ArticuloPrecios { get; set; }
        public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; }
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicos { get; set; }
        public virtual ICollection<BomArticuloDet> BomArticuloDets { get; set; }
        public virtual ICollection<BomArticulo> BomArticulos { get; set; }
        public virtual ICollection<ClasificAdiArticulo> ClasificAdiArticulos { get; set; }
        public virtual ICollection<ClasificacionVentum> ClasificacionVenta { get; set; }
        public virtual ICollection<CostoStdDesgl> CostoStdDesgls { get; set; }
        public virtual ICollection<CostoUepsPep> CostoUepsPeps { get; set; }
        public virtual ICollection<CsOrdenProduccionBcfood> CsOrdenProduccionBcfoods { get; set; }
        public virtual ICollection<CsOrdenProduccion> CsOrdenProduccions { get; set; }
        public virtual ICollection<CsRecetaLinea> CsRecetaLineas { get; set; }
        public virtual ICollection<CsSerie> CsSeries { get; set; }
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<EscalaBonif> EscalaBonifArticuloBonifNavigations { get; set; }
        public virtual ICollection<EscalaBonif> EscalaBonifArticuloNavigations { get; set; }
        public virtual ICollection<EscalaDcto> EscalaDctos { get; set; }
        public virtual ICollection<ExcepcionD104> ExcepcionD104s { get; set; }
        public virtual ICollection<ExistenciaBodega> ExistenciaBodegas { get; set; }
        public virtual ICollection<ExistenciaCierre> ExistenciaCierres { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<GarantiasDocCc> GarantiasDocCcs { get; set; }
        public virtual ICollection<GarantiasDocCo> GarantiasDocCos { get; set; }
        public virtual ICollection<GarantiasDocCp> GarantiasDocCps { get; set; }
        public virtual ICollection<GarantiasDocFa> GarantiasDocFas { get; set; }
        public virtual ICollection<GarantiasPedFa> GarantiasPedFas { get; set; }
        public virtual ICollection<ImpProceso> ImpProcesos { get; set; }
        public virtual ICollection<ImplosionDetalle> ImplosionDetalles { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<LiquidacGasto> LiquidacGastos { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public virtual ICollection<OpOperConsumo> OpOperConsumos { get; set; }
        public virtual ICollection<OpOperDetProd> OpOperDetProds { get; set; }
        public virtual ICollection<OpOperProd> OpOperProds { get; set; }
        public virtual ICollection<OrdenCompraLinea> OrdenCompraLineas { get; set; }
        public virtual ICollection<OtArticulo> OtArticulos { get; set; }
        public virtual ICollection<OtReporteConsumo> OtReporteConsumos { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridos { get; set; }
        public virtual ICollection<PrecioArtProv> PrecioArtProvs { get; set; }
        public virtual ICollection<ProcArticulo> ProcArticulos { get; set; }
        public virtual ICollection<ReglaDescuento> ReglaDescuentos { get; set; }
        public virtual ICollection<RequisicionLinea> RequisicionLineas { get; set; }
        public virtual ICollection<SolicitudOcLinea> SolicitudOcLineas { get; set; }
        public virtual ICollection<SpPronosticoDetalle> SpPronosticoDetalles { get; set; }
        public virtual ICollection<SustitutoMp> SustitutoMpMatPrimaOrigNavigations { get; set; }
        public virtual ICollection<SustitutoMp> SustitutoMpMatSubstitutoNavigations { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
