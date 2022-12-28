using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccPer1
    {
        public EmpleadoAccPer1()
        {
            AccPerImpresion1s = new HashSet<AccPerImpresion1>();
            AdminCotizante1s = new HashSet<AdminCotizante1>();
            CalcVacDetalle1s = new HashSet<CalcVacDetalle1>();
            EmpleadoAccSaldo1s = new HashSet<EmpleadoAccSaldo1>();
            EmpleadoAccidente1s = new HashSet<EmpleadoAccidente1>();
            EmpleadoAusencium1s = new HashSet<EmpleadoAusencium1>();
            Liquidacion1s = new HashSet<Liquidacion1>();
            SalDiarioIntEmp1s = new HashSet<SalDiarioIntEmp1>();
            SolicitudRh1s = new HashSet<SolicitudRh1>();
        }

        public int NumeroAccion { get; set; }
        public string? Puesto { get; set; }
        public string? Plaza { get; set; }
        public string? CentroCosto { get; set; }
        public string? Departamento { get; set; }
        public string TipoAccion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; } = null!;
        public decimal? SalarioPromedio { get; set; }
        public string? TipoAusencia { get; set; }
        public string? EstadoEmpleado { get; set; }
        public DateTime FechaRige { get; set; }
        public DateTime? FechaVence { get; set; }
        public string? Notas { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public string? AprobadaPor { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? UsuarioVigente { get; set; }
        public DateTime? FechaVigente { get; set; }
        public string? UsuarioAplicacion { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string EstadoAccion { get; set; } = null!;
        public decimal? DiasAccion { get; set; }
        public decimal? SalarioDiarioInt { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Rubro6 { get; set; }
        public string? Rubro7 { get; set; }
        public string? Rubro8 { get; set; }
        public string? Rubro9 { get; set; }
        public string? Rubro10 { get; set; }
        public decimal Saldo { get; set; }
        public string? Nomina { get; set; }
        public string? UsuarioAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string? RegimenVacacional { get; set; }
        public string? Administradora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Administradora1? AdministradoraNavigation { get; set; }
        public virtual Usuario2? AprobadaPorNavigation { get; set; }
        public virtual CentroCosto1? CentroCostoNavigation { get; set; }
        public virtual Departamento1? DepartamentoNavigation { get; set; }
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual EstadoEmpleado1? EstadoEmpleadoNavigation { get; set; }
        public virtual Nomina1? NominaNavigation { get; set; }
        public virtual Plaza1? P { get; set; }
        public virtual RegimenVacacional1? RegimenVacacionalNavigation { get; set; }
        public virtual TipoAccion1 TipoAccionNavigation { get; set; } = null!;
        public virtual TipoAusencium1? TipoAusenciaNavigation { get; set; }
        public virtual Usuario2? UsuarioAnulacionNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual Usuario2? UsuarioVigenteNavigation { get; set; }
        public virtual ICollection<AccPerImpresion1> AccPerImpresion1s { get; set; }
        public virtual ICollection<AdminCotizante1> AdminCotizante1s { get; set; }
        public virtual ICollection<CalcVacDetalle1> CalcVacDetalle1s { get; set; }
        public virtual ICollection<EmpleadoAccSaldo1> EmpleadoAccSaldo1s { get; set; }
        public virtual ICollection<EmpleadoAccidente1> EmpleadoAccidente1s { get; set; }
        public virtual ICollection<EmpleadoAusencium1> EmpleadoAusencium1s { get; set; }
        public virtual ICollection<Liquidacion1> Liquidacion1s { get; set; }
        public virtual ICollection<SalDiarioIntEmp1> SalDiarioIntEmp1s { get; set; }
        public virtual ICollection<SolicitudRh1> SolicitudRh1s { get; set; }
    }
}
