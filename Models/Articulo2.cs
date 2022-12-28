using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Articulo2
    {
        public Articulo2()
        {
            AliasProduccion2s = new HashSet<AliasProduccion2>();
            ArtUndDistribuci2s = new HashSet<ArtUndDistribuci2>();
            ArticuloAlterno2AlternoNavigations = new HashSet<ArticuloAlterno2>();
            ArticuloAlterno2ArticuloNavigations = new HashSet<ArticuloAlterno2>();
            ArticuloEnsamble2ArticuloHijoNavigations = new HashSet<ArticuloEnsamble2>();
            ArticuloEnsamble2ArticuloPadreNavigations = new HashSet<ArticuloEnsamble2>();
            ArticuloFoto2s = new HashSet<ArticuloFoto2>();
            ArticuloPrecio2s = new HashSet<ArticuloPrecio2>();
            ArticuloProveedor2s = new HashSet<ArticuloProveedor2>();
            BoletaInvFisico2s = new HashSet<BoletaInvFisico2>();
            ClasificAdiArticulo2s = new HashSet<ClasificAdiArticulo2>();
            ClasificacionVentum2s = new HashSet<ClasificacionVentum2>();
            CostoStdDesgl2s = new HashSet<CostoStdDesgl2>();
            CostoUepsPep2s = new HashSet<CostoUepsPep2>();
            DespachoDetalle2s = new HashSet<DespachoDetalle2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            EscalaBonif2ArticuloBonifNavigations = new HashSet<EscalaBonif2>();
            EscalaBonif2ArticuloNavigations = new HashSet<EscalaBonif2>();
            EscalaDcto2s = new HashSet<EscalaDcto2>();
            ExcepcionD1042s = new HashSet<ExcepcionD1042>();
            ExistenciaBodega2s = new HashSet<ExistenciaBodega2>();
            ExistenciaCierre2s = new HashSet<ExistenciaCierre2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            GarantiasDocCc2s = new HashSet<GarantiasDocCc2>();
            GarantiasDocCo2s = new HashSet<GarantiasDocCo2>();
            GarantiasDocCp2s = new HashSet<GarantiasDocCp2>();
            GarantiasDocFa2s = new HashSet<GarantiasDocFa2>();
            GarantiasPedFa2s = new HashSet<GarantiasPedFa2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
            Lote2s = new HashSet<Lote2>();
            OpOperConsumo2s = new HashSet<OpOperConsumo2>();
            OpOperDetProd2s = new HashSet<OpOperDetProd2>();
            OpOperProd2s = new HashSet<OpOperProd2>();
            OrdenCompraLinea2s = new HashSet<OrdenCompraLinea2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            PedidoSugerido2s = new HashSet<PedidoSugerido2>();
            PrecioArtProv2s = new HashSet<PrecioArtProv2>();
            ReglaDescuento2s = new HashSet<ReglaDescuento2>();
            RequisicionLinea2s = new HashSet<RequisicionLinea2>();
            SolicitudOcLinea2s = new HashSet<SolicitudOcLinea2>();
            SpPronosticoDetalle2s = new HashSet<SpPronosticoDetalle2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
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

        public virtual ArticuloCuentum2 ArticuloCuentaNavigation { get; set; } = null!;
        public virtual CatalogoExistencium2? CatalogoExistenciaNavigation { get; set; }
        public virtual Clasificacion2? Clasificacion1Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion2Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion3Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion4Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion5Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion6Navigation { get; set; }
        public virtual Retencione2? CodigoRetencionNavigation { get; set; }
        public virtual ArticuloColor2? ColorNavigation { get; set; }
        public virtual ArticuloEstilo2? EstiloNavigation { get; set; }
        public virtual Impuesto2 ImpuestoNavigation { get; set; } = null!;
        public virtual ItemsHaciendum2? ItemHaciendaNavigation { get; set; }
        public virtual ModeloRetencion2? ModeloRetencionNavigation { get; set; }
        public virtual Nit2? NitNavigation { get; set; }
        public virtual SeriePlantilla2? PlantillaSerieNavigation { get; set; }
        public virtual Proveedor2? ProveedorNavigation { get; set; }
        public virtual Retencione2? RetencionCompraNavigation { get; set; }
        public virtual ArticuloTalla2? TallaNavigation { get; set; }
        public virtual TipoExistencium2? TipoExistenciaNavigation { get; set; }
        public virtual TiposDetraccione2? TiposDetraccione2 { get; set; }
        public virtual TiposDetraccione2? TiposDetraccione2Navigation { get; set; }
        public virtual UnidadDeMedidum2 UnidadAlmacenNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum2 UnidadEmpaqueNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum2 UnidadVentaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModifNavigation { get; set; }
        public virtual ArticuloCompra2 ArticuloCompra2 { get; set; } = null!;
        public virtual CostStdBatch2 CostStdBatch2 { get; set; } = null!;
        public virtual ICollection<AliasProduccion2> AliasProduccion2s { get; set; }
        public virtual ICollection<ArtUndDistribuci2> ArtUndDistribuci2s { get; set; }
        public virtual ICollection<ArticuloAlterno2> ArticuloAlterno2AlternoNavigations { get; set; }
        public virtual ICollection<ArticuloAlterno2> ArticuloAlterno2ArticuloNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble2> ArticuloEnsamble2ArticuloHijoNavigations { get; set; }
        public virtual ICollection<ArticuloEnsamble2> ArticuloEnsamble2ArticuloPadreNavigations { get; set; }
        public virtual ICollection<ArticuloFoto2> ArticuloFoto2s { get; set; }
        public virtual ICollection<ArticuloPrecio2> ArticuloPrecio2s { get; set; }
        public virtual ICollection<ArticuloProveedor2> ArticuloProveedor2s { get; set; }
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2s { get; set; }
        public virtual ICollection<ClasificAdiArticulo2> ClasificAdiArticulo2s { get; set; }
        public virtual ICollection<ClasificacionVentum2> ClasificacionVentum2s { get; set; }
        public virtual ICollection<CostoStdDesgl2> CostoStdDesgl2s { get; set; }
        public virtual ICollection<CostoUepsPep2> CostoUepsPep2s { get; set; }
        public virtual ICollection<DespachoDetalle2> DespachoDetalle2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<EscalaBonif2> EscalaBonif2ArticuloBonifNavigations { get; set; }
        public virtual ICollection<EscalaBonif2> EscalaBonif2ArticuloNavigations { get; set; }
        public virtual ICollection<EscalaDcto2> EscalaDcto2s { get; set; }
        public virtual ICollection<ExcepcionD1042> ExcepcionD1042s { get; set; }
        public virtual ICollection<ExistenciaBodega2> ExistenciaBodega2s { get; set; }
        public virtual ICollection<ExistenciaCierre2> ExistenciaCierre2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<GarantiasDocCc2> GarantiasDocCc2s { get; set; }
        public virtual ICollection<GarantiasDocCo2> GarantiasDocCo2s { get; set; }
        public virtual ICollection<GarantiasDocCp2> GarantiasDocCp2s { get; set; }
        public virtual ICollection<GarantiasDocFa2> GarantiasDocFa2s { get; set; }
        public virtual ICollection<GarantiasPedFa2> GarantiasPedFa2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
        public virtual ICollection<Lote2> Lote2s { get; set; }
        public virtual ICollection<OpOperConsumo2> OpOperConsumo2s { get; set; }
        public virtual ICollection<OpOperDetProd2> OpOperDetProd2s { get; set; }
        public virtual ICollection<OpOperProd2> OpOperProd2s { get; set; }
        public virtual ICollection<OrdenCompraLinea2> OrdenCompraLinea2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2s { get; set; }
        public virtual ICollection<PrecioArtProv2> PrecioArtProv2s { get; set; }
        public virtual ICollection<ReglaDescuento2> ReglaDescuento2s { get; set; }
        public virtual ICollection<RequisicionLinea2> RequisicionLinea2s { get; set; }
        public virtual ICollection<SolicitudOcLinea2> SolicitudOcLinea2s { get; set; }
        public virtual ICollection<SpPronosticoDetalle2> SpPronosticoDetalle2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
