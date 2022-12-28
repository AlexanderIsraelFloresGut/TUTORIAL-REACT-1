using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAccPer2
    {
        public EmpleadoAccPer2()
        {
            AccPerImpresion2s = new HashSet<AccPerImpresion2>();
            AdminCotizante2s = new HashSet<AdminCotizante2>();
            CalcVacDetalle2s = new HashSet<CalcVacDetalle2>();
            EmpleadoAccSaldo2s = new HashSet<EmpleadoAccSaldo2>();
            EmpleadoAccidente2s = new HashSet<EmpleadoAccidente2>();
            EmpleadoAusencium2s = new HashSet<EmpleadoAusencium2>();
            Liquidacion2s = new HashSet<Liquidacion2>();
            SalDiarioIntEmp2s = new HashSet<SalDiarioIntEmp2>();
            SolicitudRh2s = new HashSet<SolicitudRh2>();
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

        public virtual Administradora2? AdministradoraNavigation { get; set; }
        public virtual Usuario2? AprobadaPorNavigation { get; set; }
        public virtual CentroCosto2? CentroCostoNavigation { get; set; }
        public virtual Departamento2? DepartamentoNavigation { get; set; }
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual EstadoEmpleado2? EstadoEmpleadoNavigation { get; set; }
        public virtual Nomina2? NominaNavigation { get; set; }
        public virtual Plaza2? P { get; set; }
        public virtual RegimenVacacional2? RegimenVacacionalNavigation { get; set; }
        public virtual TipoAccion2 TipoAccionNavigation { get; set; } = null!;
        public virtual TipoAusencium2? TipoAusenciaNavigation { get; set; }
        public virtual Usuario2? UsuarioAnulacionNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicacionNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual Usuario2? UsuarioVigenteNavigation { get; set; }
        public virtual ICollection<AccPerImpresion2> AccPerImpresion2s { get; set; }
        public virtual ICollection<AdminCotizante2> AdminCotizante2s { get; set; }
        public virtual ICollection<CalcVacDetalle2> CalcVacDetalle2s { get; set; }
        public virtual ICollection<EmpleadoAccSaldo2> EmpleadoAccSaldo2s { get; set; }
        public virtual ICollection<EmpleadoAccidente2> EmpleadoAccidente2s { get; set; }
        public virtual ICollection<EmpleadoAusencium2> EmpleadoAusencium2s { get; set; }
        public virtual ICollection<Liquidacion2> Liquidacion2s { get; set; }
        public virtual ICollection<SalDiarioIntEmp2> SalDiarioIntEmp2s { get; set; }
        public virtual ICollection<SolicitudRh2> SolicitudRh2s { get; set; }
    }
}
