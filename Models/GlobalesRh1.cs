using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesRh1
    {
        public string? DefRubro10Accper { get; set; }
        public string? DefRubro4Accper { get; set; }
        public string? DefRubro2Accper { get; set; }
        public string? DefRubro3Accper { get; set; }
        public int UltimaAccion { get; set; }
        public string UsaPlaza { get; set; } = null!;
        public string ModPlazaPorEmp { get; set; } = null!;
        public string? Rubro1Nombre { get; set; }
        public string? Rubro2Nombre { get; set; }
        public string? Rubro3Nombre { get; set; }
        public string? Rubro4Nombre { get; set; }
        public string? Rubro5Nombre { get; set; }
        public string UsaRubro { get; set; } = null!;
        public string GeneraContrato { get; set; } = null!;
        public string? TipoAccionCont { get; set; }
        public string? Paquete { get; set; }
        public string? TipoAsiento { get; set; }
        public short ModAplicAsiento { get; set; }
        public string TipoContaOmision { get; set; } = null!;
        public string? CentroCostoLiq { get; set; }
        public string? CuentaContaLiq { get; set; }
        public string UsaSalarioDiario { get; set; } = null!;
        public string UsaRubrosAccper { get; set; } = null!;
        public string? EstadoEmpCont { get; set; }
        public string? TipoSalario { get; set; }
        public int UltimaLiquidacion { get; set; }
        public string? TipoAccionLiq { get; set; }
        public string? EstadoEmpLiq { get; set; }
        public string? FormatoLiquidac { get; set; }
        public string? NotasLiquidacion { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string? DefRubro1Accper { get; set; }
        public string? DefRubro5Accper { get; set; }
        public string? DefRubro9Accper { get; set; }
        public string? DefRubro8Accper { get; set; }
        public string? DefRubro6Accper { get; set; }
        public string? DefRubro7Accper { get; set; }
        public string? UsaNombresSep { get; set; }
        public short? SubtdocChkLiq { get; set; }
        public short? SubtdocTefLiq { get; set; }
        public string? EMailRh { get; set; }
        public string? EstadoEmpNuevo { get; set; }
        public short? DiasAmpliaCont { get; set; }
        public string? TipoAccionAcum { get; set; }
        public string? TipoAccionPago { get; set; }
        public string? TipoAusenciaPago { get; set; }
        public string? TipoAccAcumAdic { get; set; }
        public string? TipoAccPagAdic { get; set; }
        public string? TipoAusPagAdic { get; set; }
        public string? TipoAccIncAcum { get; set; }
        public string? TipoAccIncDism { get; set; }
        public string? IntegracionCr { get; set; }
        public string? RequierePresup { get; set; }
        public string? PaqueteCr { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? TipoAccIncAjust { get; set; }
        public string AprobAdicional { get; set; } = null!;
        public string InfoHistorica { get; set; } = null!;
        public string UsaControlSalarios { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string HorasIncap { get; set; } = null!;
        public string? TipoAccionCapaNeg { get; set; }
        public string? TipoAccionCapaAdicNeg { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual EstadoEmpleado1? EstadoEmpContNavigation { get; set; }
        public virtual EstadoEmpleado1? EstadoEmpLiqNavigation { get; set; }
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual TipoAccion1? TipoAccAcumAdicNavigation { get; set; }
        public virtual TipoAccion1? TipoAccIncAcumNavigation { get; set; }
        public virtual TipoAccion1? TipoAccIncDismNavigation { get; set; }
        public virtual TipoAccion1? TipoAccPagAdicNavigation { get; set; }
        public virtual TipoAccion1? TipoAccionAcumNavigation { get; set; }
        public virtual TipoAccion1? TipoAccionContNavigation { get; set; }
        public virtual TipoAccion1? TipoAccionLiqNavigation { get; set; }
        public virtual TipoAccion1? TipoAccionPagoNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual TipoAusencium1? TipoAusPagAdicNavigation { get; set; }
        public virtual TipoAusencium1? TipoAusenciaPagoNavigation { get; set; }
    }
}
