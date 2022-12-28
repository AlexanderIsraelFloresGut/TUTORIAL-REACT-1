using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenTrabajo1
    {
        public OrdenTrabajo1()
        {
            Equipo1s = new HashSet<Equipo1>();
            Medicion1s = new HashSet<Medicion1>();
            OtArticulo1s = new HashSet<OtArticulo1>();
            OtDetalle1s = new HashSet<OtDetalle1>();
            OtEquipo1s = new HashSet<OtEquipo1>();
            OtGasto1s = new HashSet<OtGasto1>();
            OtNota1s = new HashSet<OtNota1>();
            OtPuesto1s = new HashSet<OtPuesto1>();
            ReporteLabor1s = new HashSet<ReporteLabor1>();
            SolicitudTrabajo1s = new HashSet<SolicitudTrabajo1>();
        }

        public int OrdenTrabajo { get; set; }
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

        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual CentroCosto1? CentroGastoNavigation { get; set; }
        public virtual Empleado1? EmpSolicitanteNavigation { get; set; }
        public virtual Empleado1? EmpleadoEntregaNavigation { get; set; }
        public virtual Empleado1? EmpleadoRecibeNavigation { get; set; }
        public virtual Turno1? TurnoEntregaNavigation { get; set; }
        public virtual Turno1? TurnoRecepcionNavigation { get; set; }
        public virtual Turno1? TurnoSolicitudNavigation { get; set; }
        public virtual Usuario2? UsuarioCierreNavigation { get; set; }
        public virtual Usuario2 UsuarioCreaNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiberacionNavigation { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<Medicion1> Medicion1s { get; set; }
        public virtual ICollection<OtArticulo1> OtArticulo1s { get; set; }
        public virtual ICollection<OtDetalle1> OtDetalle1s { get; set; }
        public virtual ICollection<OtEquipo1> OtEquipo1s { get; set; }
        public virtual ICollection<OtGasto1> OtGasto1s { get; set; }
        public virtual ICollection<OtNota1> OtNota1s { get; set; }
        public virtual ICollection<OtPuesto1> OtPuesto1s { get; set; }
        public virtual ICollection<ReporteLabor1> ReporteLabor1s { get; set; }
        public virtual ICollection<SolicitudTrabajo1> SolicitudTrabajo1s { get; set; }
    }
}
