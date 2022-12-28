using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoConcNomi
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string FormaAplicacion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }
        public short? NumeroLiquidac { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public string TipoRegistro { get; set; } = null!;

        public virtual CentroConcepto C { get; set; } = null!;
        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico N { get; set; } = null!;
        public virtual NominaConcepto NominaConcepto { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
    }
}
