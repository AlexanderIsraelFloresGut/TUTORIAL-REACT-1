using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenTrabajo
    {
        public OrdenTrabajo()
        {
            Equipos = new HashSet<Equipo>();
            Medicions = new HashSet<Medicion>();
            OtArticulos = new HashSet<OtArticulo>();
            OtDetalles = new HashSet<OtDetalle>();
            OtEquipos = new HashSet<OtEquipo>();
            OtGastos = new HashSet<OtGasto>();
            OtNota = new HashSet<OtNota>();
            OtPuestos = new HashSet<OtPuesto>();
            ReporteLabors = new HashSet<ReporteLabor>();
            SolicitudTrabajos = new HashSet<SolicitudTrabajo>();
        }

        public int OrdenTrabajo1 { get; set; }
        public string DescripcionCorta { get; set; } = null!;
        public string? EmpSolicitante { get; set; }
        public short? TurnoSolicitud { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string? CentroGasto { get; set; }
        public string? EmpleadoRecibe { get; set; }
        public short? TurnoRecepcion { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string? EmpleadoEntrega { get; set; }
        public short? TurnoEntrega { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Bodega { get; set; } = null!;
        public string AfectaProduccion { get; set; } = null!;
        public string TipoMantenimiento { get; set; } = null!;
        public string TrabajoAprobado { get; set; } = null!;
        public string Prioridad { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaOrden { get; set; }
        public DateTime FechaRequerida { get; set; }
        public DateTime? FechaPrometida { get; set; }
        public DateTime? FechaRequeridaIn { get; set; }
        public decimal CostoEstMatLoc { get; set; }
        public decimal CostoEstMatDol { get; set; }
        public decimal CostoAcuMatLoc { get; set; }
        public decimal CostoAcuMatDol { get; set; }
        public decimal CostoEstMoLoc { get; set; }
        public decimal CostoEstMoDol { get; set; }
        public decimal CostoAcuMoLoc { get; set; }
        public decimal CostoAcuMoDol { get; set; }
        public decimal HorasAgreEst { get; set; }
        public decimal HorasAgreReal { get; set; }
        public decimal HorasCronoEst { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string? UsuarioLiberacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public string? UsuarioCierre { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string? Asiento { get; set; }
        public DateTime? FechaContabilizac { get; set; }
        public string? UnidadMedicion { get; set; }
        public string? PuntoMedicion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual CentroCosto? CentroGastoNavigation { get; set; }
        public virtual Empleado? EmpSolicitanteNavigation { get; set; }
        public virtual Empleado? EmpleadoEntregaNavigation { get; set; }
        public virtual Empleado? EmpleadoRecibeNavigation { get; set; }
        public virtual Turno? TurnoEntregaNavigation { get; set; }
        public virtual Turno? TurnoRecepcionNavigation { get; set; }
        public virtual Turno? TurnoSolicitudNavigation { get; set; }
        public virtual Usuario2? UsuarioCierreNavigation { get; set; }
        public virtual Usuario2 UsuarioCreaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiberacionNavigation { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<Medicion> Medicions { get; set; }
        public virtual ICollection<OtArticulo> OtArticulos { get; set; }
        public virtual ICollection<OtDetalle> OtDetalles { get; set; }
        public virtual ICollection<OtEquipo> OtEquipos { get; set; }
        public virtual ICollection<OtGasto> OtGastos { get; set; }
        public virtual ICollection<OtNota> OtNota { get; set; }
        public virtual ICollection<OtPuesto> OtPuestos { get; set; }
        public virtual ICollection<ReporteLabor> ReporteLabors { get; set; }
        public virtual ICollection<SolicitudTrabajo> SolicitudTrabajos { get; set; }
    }
}
