using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccPer
    {
        public EmpleadoAccPer()
        {
            AccPerImpresions = new HashSet<AccPerImpresion>();
            AdminCotizantes = new HashSet<AdminCotizante>();
            CalcVacDetalles = new HashSet<CalcVacDetalle>();
            EmpleadoAccSaldos = new HashSet<EmpleadoAccSaldo>();
            EmpleadoAccidentes = new HashSet<EmpleadoAccidente>();
            EmpleadoAusencia = new HashSet<EmpleadoAusencium>();
            Liquidacions = new HashSet<Liquidacion>();
            SalDiarioIntEmps = new HashSet<SalDiarioIntEmp>();
            SolicitudRhs = new HashSet<SolicitudRh>();
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

        public virtual Administradora? AdministradoraNavigation { get; set; }
        public virtual Usuario2? AprobadaPorNavigation { get; set; }
        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual Departamento? DepartamentoNavigation { get; set; }
        public virtual Empleado EmpleadoNavigation { get; set; } = null!;
        public virtual EstadoEmpleado? EstadoEmpleadoNavigation { get; set; }
        public virtual Nomina? NominaNavigation { get; set; }
        public virtual Plaza? P { get; set; }
        public virtual RegimenVacacional? RegimenVacacionalNavigation { get; set; }
        public virtual TipoAccion TipoAccionNavigation { get; set; } = null!;
        public virtual TipoAusencium? TipoAusenciaNavigation { get; set; }
        public virtual Usuario2? UsuarioAnulacionNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual Usuario2? UsuarioVigenteNavigation { get; set; }
        public virtual ICollection<AccPerImpresion> AccPerImpresions { get; set; }
        public virtual ICollection<AdminCotizante> AdminCotizantes { get; set; }
        public virtual ICollection<CalcVacDetalle> CalcVacDetalles { get; set; }
        public virtual ICollection<EmpleadoAccSaldo> EmpleadoAccSaldos { get; set; }
        public virtual ICollection<EmpleadoAccidente> EmpleadoAccidentes { get; set; }
        public virtual ICollection<EmpleadoAusencium> EmpleadoAusencia { get; set; }
        public virtual ICollection<Liquidacion> Liquidacions { get; set; }
        public virtual ICollection<SalDiarioIntEmp> SalDiarioIntEmps { get; set; }
        public virtual ICollection<SolicitudRh> SolicitudRhs { get; set; }
    }
}
