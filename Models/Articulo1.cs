using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Articulo1
    {
        public Articulo1()
        {
            AliasProduccion1s = new HashSet<AliasProduccion1>();
            ArtUndDistribuci1s = new HashSet<ArtUndDistribuci1>();
            ArticuloAlterno1AlternoNavigations = new HashSet<ArticuloAlterno1>();
            ArticuloAlterno1ArticuloNavigations = new HashSet<ArticuloAlterno1>();
            ArticuloEnsamble1ArticuloHijoNavigations = new HashSet<ArticuloEnsamble1>();
            ArticuloEnsamble1ArticuloPadreNavigations = new HashSet<ArticuloEnsamble1>();
            ArticuloFoto1s = new HashSet<ArticuloFoto1>();
            ArticuloPrecio1s = new HashSet<ArticuloPrecio1>();
            ArticuloProveedor1s = new HashSet<ArticuloProveedor1>();
            BoletaInvFisico1s = new HashSet<BoletaInvFisico1>();
            BomArticulo1s = new HashSet<BomArticulo1>();
            BomArticuloDet1s = new HashSet<BomArticuloDet1>();
            ClasificAdiArticulo1s = new HashSet<ClasificAdiArticulo1>();
            ClasificacionVentum1s = new HashSet<ClasificacionVentum1>();
            CostoStdDesgl1s = new HashSet<CostoStdDesgl1>();
            CostoUepsPep1s = new HashSet<CostoUepsPep1>();
            DespachoDetalle1s = new HashSet<DespachoDetalle1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            EscalaBonif1ArticuloBonifNavigations = new HashSet<EscalaBonif1>();
            EscalaBonif1ArticuloNavigations = new HashSet<EscalaBonif1>();
            EscalaDcto1s = new HashSet<EscalaDcto1>();
            ExcepcionD1041s = new HashSet<ExcepcionD1041>();
            ExistenciaBodega1s = new HashSet<ExistenciaBodega1>();
            ExistenciaCierre1s = new HashSet<ExistenciaCierre1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            GarantiasDocCc1s = new HashSet<GarantiasDocCc1>();
            GarantiasDocCo1s = new HashSet<GarantiasDocCo1>();
            GarantiasDocCp1s = new HashSet<GarantiasDocCp1>();
            GarantiasDocFa1s = new HashSet<GarantiasDocFa1>();
            GarantiasPedFa1s = new HashSet<GarantiasPedFa1>();
            ImpProceso1s = new HashSet<ImpProceso1>();
            ImplosionDetalle1s = new HashSet<ImplosionDetalle1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
            Lote1s = new HashSet<Lote1>();
            OpOperConsumo1s = new HashSet<OpOperConsumo1>();
            OpOperDetProd1s = new HashSet<OpOperDetProd1>();
            OpOperProd1s = new HashSet<OpOperProd1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            OtArticulo1s = new HashSet<OtArticulo1>();
            OtReporteConsumo1s = new HashSet<OtReporteConsumo1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            PedidoSugerido1s = new HashSet<PedidoSugerido1>();
            PrecioArtProv1s = new HashSet<PrecioArtProv1>();
            ProcArticulo1s = new HashSet<ProcArticulo1>();
            ReglaDescuento1s = new HashSet<ReglaDescuento1>();
            RequisicionLinea1s = new HashSet<RequisicionLinea1>();
            SolicitudOcLinea1s = new HashSet<SolicitudOcLinea1>();
            SpPronosticoDetalle1s = new HashSet<SpPronosticoDetalle1>();
            SustitutoMp1MatPrimaOrigNavigations = new HashSet<SustitutoMp1>();
            SustitutoMp1MatSubstitutoNavigations = new HashSet<SustitutoMp1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
        }

        public string Articulo { get; set; } = null!;
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
        public decimal CantidadProduccion { get; set; }
        public decimal? Rendimiento { get; set; }
        public string? USerie { get; set; }
        public string? UWalmart { get; set; }
        public string? UVtaLocal { get; set; }
        public string? UFresco { get; set; }
        public string? UCongelado { get; set; }
        public string UPresentacion { get; set; } = null!;
        public string UReintegro { get; set; } = null!;
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

        public virtual ArticuloCuentum1 ArticuloCuentaNavigation { get; set; } = null!;
        public virtual CatalogoExistencium1? CatalogoExistenciaNavigation { get; set; }
        public virtual Clasificacion1? Clasificacion1Navigation { get; set; }
        public virtual Clasificacion1? Clasificacion2Navigation { get; set; }
        public virtual Clasificacion1? Clasificacion3Navigation { get; set; }
        public virtual Clasificacion1? Clasificacion4Navigation { get; set; }
        public virtual Clasificacion1? Clasificacion5Navigation { get; set; }
        public virtual Clasificacion1? Clasificacion6Navigation { get; set; }
        public virtual Retencione1? CodigoRetencionNavigation { get; set; }
        public virtual ArticuloColor1? ColorNavigation { get; set; }
        public virtual ArticuloEstilo1? EstiloNavigation { get; set; }
        public virtual Impuesto1 ImpuestoNavigation { get; set; } = null!;
        public virtual ItemsHaciendum1? ItemHaciendaNavigation { get; set; }
        public virtual ModeloRetencion1? ModeloRetencionNavigation { get; set; }
        public virtual Nit1? NitNavigation { get; set; }
        public virtual SeriePlantilla1? PlantillaSerieNavigation { get; set; }
        public virtual Proveedor1? ProveedorNavigation { get; set; }
        public virtual Retencione1? RetencionCompraNavigation { get; set; }
        public virtual ArticuloTalla1? TallaNavigation { get; set; }
        public virtual TipoExistencium1? TipoExistenciaNavigation { get; set; }
        public virtual TiposDetraccione1? TiposDetraccione1 { get; set; }
        public virtual TiposDetraccione1? TiposDetraccione1Navigation { get; set; }
        public virtual UnidadDeMedidum1 UnidadAlmacenNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum1 UnidadEmpaqueNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum1 UnidadVentaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ArticuloCompra1 ArticuloCompra1 { get; set; } = null!;
        public virtual CostStdBatch1 CostStdBatch1 { get; set; } = null!;
        public virtual ICollection<AliasProduccion1> AliasProduccion1s { get; set; }
        public virtual ICollection<ArtUndDistribuci1> ArtUndDistribuci1s { get; set; }
        public virtual ICollection<ArticuloAlterno1> ArticuloAlterno1AlternoNavigations { get; set; }
        public virtual ICollection<ArticuloAlterno1> ArticuloAlterno1ArticuloNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble1> ArticuloEnsamble1ArticuloHijoNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble1> ArticuloEnsamble1ArticuloPadreNavigations { get; set; }
        public virtual ICollection<ArticuloFoto1> ArticuloFoto1s { get; set; }
        public virtual ICollection<ArticuloPrecio1> ArticuloPrecio1s { get; set; }
        public virtual ICollection<ArticuloProveedor1> ArticuloProveedor1s { get; set; }
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1s { get; set; }
        public virtual ICollection<BomArticulo1> BomArticulo1s { get; set; }
        public virtual ICollection<BomArticuloDet1> BomArticuloDet1s { get; set; }
        public virtual ICollection<ClasificAdiArticulo1> ClasificAdiArticulo1s { get; set; }
        public virtual ICollection<ClasificacionVentum1> ClasificacionVentum1s { get; set; }
        public virtual ICollection<CostoStdDesgl1> CostoStdDesgl1s { get; set; }
        public virtual ICollection<CostoUepsPep1> CostoUepsPep1s { get; set; }
        public virtual ICollection<DespachoDetalle1> DespachoDetalle1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<EscalaBonif1> EscalaBonif1ArticuloBonifNavigations { get; set; }
        public virtual ICollection<EscalaBonif1> EscalaBonif1ArticuloNavigations { get; set; }
        public virtual ICollection<EscalaDcto1> EscalaDcto1s { get; set; }
        public virtual ICollection<ExcepcionD1041> ExcepcionD1041s { get; set; }
        public virtual ICollection<ExistenciaBodega1> ExistenciaBodega1s { get; set; }
        public virtual ICollection<ExistenciaCierre1> ExistenciaCierre1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<GarantiasDocCc1> GarantiasDocCc1s { get; set; }
        public virtual ICollection<GarantiasDocCo1> GarantiasDocCo1s { get; set; }
        public virtual ICollection<GarantiasDocCp1> GarantiasDocCp1s { get; set; }
        public virtual ICollection<GarantiasDocFa1> GarantiasDocFa1s { get; set; }
        public virtual ICollection<GarantiasPedFa1> GarantiasPedFa1s { get; set; }
        public virtual ICollection<ImpProceso1> ImpProceso1s { get; set; }
        public virtual ICollection<ImplosionDetalle1> ImplosionDetalle1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
        public virtual ICollection<Lote1> Lote1s { get; set; }
        public virtual ICollection<OpOperConsumo1> OpOperConsumo1s { get; set; }
        public virtual ICollection<OpOperDetProd1> OpOperDetProd1s { get; set; }
        public virtual ICollection<OpOperProd1> OpOperProd1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<OtArticulo1> OtArticulo1s { get; set; }
        public virtual ICollection<OtReporteConsumo1> OtReporteConsumo1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1s { get; set; }
        public virtual ICollection<PrecioArtProv1> PrecioArtProv1s { get; set; }
        public virtual ICollection<ProcArticulo1> ProcArticulo1s { get; set; }
        public virtual ICollection<ReglaDescuento1> ReglaDescuento1s { get; set; }
        public virtual ICollection<RequisicionLinea1> RequisicionLinea1s { get; set; }
        public virtual ICollection<SolicitudOcLinea1> SolicitudOcLinea1s { get; set; }
        public virtual ICollection<SpPronosticoDetalle1> SpPronosticoDetalle1s { get; set; }
        public virtual ICollection<SustitutoMp1> SustitutoMp1MatPrimaOrigNavigations { get; set; }
        public virtual ICollection<SustitutoMp1> SustitutoMp1MatSubstitutoNavigations { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
