using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesPc
    {
        public string? PatronOrden { get; set; }
        public string TipoConsecutivo { get; set; } = null!;
        public string? UltimaOrden { get; set; }
        public string ReservAlLiberar { get; set; } = null!;
        public string LiberarExistencia { get; set; } = null!;
        public short DecimalesCantidad { get; set; }
        public short DecimalesCostos { get; set; }
        public string BodegaPt { get; set; } = null!;
        public string CambiarBodePt { get; set; } = null!;
        public string CambiarBodeMp { get; set; } = null!;
        public string CostoIngresoPt { get; set; } = null!;
        public string CambiarCostoPt { get; set; } = null!;
        public string CostoIngresoOp { get; set; } = null!;
        public string CambiarCostoOp { get; set; } = null!;
        public string AjustarEstimado { get; set; } = null!;
        public string ModificarStd { get; set; } = null!;
        public short PrioridadDefault { get; set; }
        public short PrioridadTope { get; set; }
        public string AsLineaCv { get; set; } = null!;
        public string AsLineaMoGif { get; set; } = null!;
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string TipoCambio { get; set; } = null!;
        public string? UltimaRequisicion { get; set; }
        public string? CtrIndirectosenpr { get; set; }
        public string? CtaIndirectosenpr { get; set; }
        public string? CtrManodeobraenpr { get; set; }
        public string? CtaManodeobraenpr { get; set; }
        public string? CtrIndirectosapli { get; set; }
        public string? CtaIndirectosapli { get; set; }
        public string? CtrManodeobraapli { get; set; }
        public string? CtaManodeobraapli { get; set; }
        public string? CtrMaterialesvari { get; set; }
        public string? CtaMaterialesvari { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string TipoContaOmision { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string BodegaMp { get; set; } = null!;
        public string? TomaEstrucModif { get; set; }
        public string? PatronLiquidacion { get; set; }
        public string ObligContAlLiq { get; set; } = null!;
        public string LiquidAfectaInv { get; set; } = null!;
        public string UsaLiquidacion { get; set; } = null!;
        public string ObligaClientes { get; set; } = null!;
        public string ClienteEstructura { get; set; } = null!;
        public string ProcesoLiberacion { get; set; } = null!;
        public string LiberarOperacion { get; set; } = null!;
        public string? CosteaDesgloseGif { get; set; }
        public string? ConsecConsumo { get; set; }
        public string? ConsecProduc { get; set; }
        public string UsaBackflush { get; set; } = null!;
        public string ConsumirDesde { get; set; } = null!;
        public string IngresarAInvent { get; set; } = null!;
        public string ConsumoManual { get; set; } = null!;
        public decimal? Factor { get; set; }
        public decimal? Equivalencia { get; set; }
        public string? ConsecOrden { get; set; }
        public string? CtrInddesperdicios { get; set; }
        public string? CtaInddesperdicios { get; set; }
        public string? CtrMobradesperdicio { get; set; }
        public string? CtaMobradesperdicio { get; set; }
        public decimal MaxVariacionCosto { get; set; }
        public string ContaAjustePp { get; set; } = null!;
        public string ContaAjusteCo { get; set; } = null!;
        public string CargaDetalleMoACn { get; set; } = null!;
        public string CosteoConDesgloseMo { get; set; } = null!;
        public string UsaCentroCosto { get; set; } = null!;
        public string UsaProrrateo { get; set; } = null!;
        public string? MetodoProrrateo { get; set; }
        public string? ClasificacionProrrateo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega BodegaMpNavigation { get; set; } = null!;
        public virtual Bodega BodegaPtNavigation { get; set; } = null!;
        public virtual ConsecutivoCi? ConsecConsumoNavigation { get; set; }
        public virtual ConsecutivoCi? ConsecProducNavigation { get; set; }
        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual TipoCambio TipoCambioNavigation { get; set; } = null!;
    }
}
