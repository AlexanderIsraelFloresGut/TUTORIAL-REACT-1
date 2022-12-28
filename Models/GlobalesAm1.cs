using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesAm1
    {
        public string? BodegaDefault { get; set; }
        public string? TipoCambio { get; set; }
        public string? Paquete { get; set; }
        public string? TipoAsiento { get; set; }
        public string? CentroGasto { get; set; }
        public string IntegracionConta { get; set; } = null!;
        public string TipoContaOmision { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string? CtrManteProceso { get; set; }
        public string? CtaManteProceso { get; set; }
        public string? CtrMoAplic { get; set; }
        public string? CtaMoAplic { get; set; }
        public string? CtrGastosVarios { get; set; }
        public string? CtaGastosVarios { get; set; }
        public string? UnidadMedDia { get; set; }
        public short PorcAdverConsumo { get; set; }
        public string LibOtSinTrabajo { get; set; } = null!;
        public string AyudaDeProc { get; set; } = null!;
        public string AsociarProcAuto { get; set; } = null!;
        public string? SalarioEstiPuest { get; set; }
        public string? SalarioRealEmp { get; set; }
        public string CostoEstiMat { get; set; } = null!;
        public string ActualizarEstiOt { get; set; } = null!;
        public string BorrarTrabProg { get; set; } = null!;
        public string HoraNormal { get; set; } = null!;
        public string HoraExtra { get; set; } = null!;
        public string HoraDoble { get; set; } = null!;
        public decimal FactorExtra { get; set; }
        public decimal FactorDoble { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega1? BodegaDefaultNavigation { get; set; }
        public virtual CentroCosto1? CentroGastoNavigation { get; set; }
        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? Ct1 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual TipoCambio1? TipoCambioNavigation { get; set; }
    }
}
