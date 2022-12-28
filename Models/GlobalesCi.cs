using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCi
    {
        public short CostosDec { get; set; }
        public short ExistenciasDec { get; set; }
        public short PesosDec { get; set; }
        public string CostoFiscal { get; set; } = null!;
        public string CostoComparativo { get; set; } = null!;
        public string CostoIngrDefault { get; set; } = null!;
        public string UnidadPeso { get; set; } = null!;
        public string UnidadVolumen { get; set; } = null!;
        public string UsaLocalizacion { get; set; } = null!;
        public string AjustarConteo { get; set; } = null!;
        public int MaxAuditoria { get; set; }
        public DateTime FchUltProcVcto { get; set; }
        public DateTime FchUltProcAprob { get; set; }
        public DateTime FechaInicioTrans { get; set; }
        public string PurgarCapasCosto { get; set; } = null!;
        public string NombreClasif1 { get; set; } = null!;
        public string NombreClasif2 { get; set; } = null!;
        public string NombreClasif3 { get; set; } = null!;
        public string? NombreClasif4 { get; set; }
        public string? NombreClasif5 { get; set; }
        public string? NombreClasif6 { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string AsntAjuVenta { get; set; } = null!;
        public string AsntAjuConsumo { get; set; } = null!;
        public string AsntAjuCompra { get; set; } = null!;
        public string AsntAjuProduc { get; set; } = null!;
        public string AsntAjuMiscelan { get; set; } = null!;
        public string AsntAjuFisico { get; set; } = null!;
        public string AsntAjuVencim { get; set; } = null!;
        public string AsntAjuCosto { get; set; } = null!;
        public string TipoFasb52 { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string TipoContaOmision { get; set; } = null!;
        public string CtrEnTransaccion { get; set; } = null!;
        public string ExistEnTotales { get; set; } = null!;
        public string TransacXUsuario { get; set; } = null!;
        public string UsaConsecutivos { get; set; } = null!;
        public string? ModalidadUso { get; set; }
        public string UsarNumerosSerie { get; set; } = null!;
        public string CntrlSeriesEntr { get; set; } = null!;
        public string UsaCodigoBarras { get; set; } = null!;
        public string? UsaUnidadesDist { get; set; }
        public string? AsistenciaAutomat { get; set; }
        public string? UsaCodigoEan13 { get; set; }
        public string? UsaCodigoEan8 { get; set; }
        public string? UsaCodigoUcc12 { get; set; }
        public string? UsaCodigoUcc8 { get; set; }
        public string? Ean13ReglaLocal { get; set; }
        public string? Ean8ReglaLocal { get; set; }
        public string? Ucc12ReglaLocal { get; set; }
        public string? PrioridadBusqueda { get; set; }
        public string UsaPedimentos { get; set; } = null!;
        public string? UsaCodigoGeneric { get; set; }
        public int? LineasMaxTrans { get; set; }
        public string? UsarAprobacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
    }
}
