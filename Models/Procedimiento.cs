using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Procedimiento
    {
        public Procedimiento()
        {
            DocsProcedims = new HashSet<DocsProcedim>();
            InverseProcedimiento2 = new HashSet<Procedimiento>();
            InverseProcedimientoNavigation = new HashSet<Procedimiento>();
            OtDetalles = new HashSet<OtDetalle>();
            ProcArticulos = new HashSet<ProcArticulo>();
            ProcEqPreventMeds = new HashSet<ProcEqPreventMed>();
            ProcEqPrevents = new HashSet<ProcEqPrevent>();
            ProcEquipos = new HashSet<ProcEquipo>();
            ProcPuestos = new HashSet<ProcPuesto>();
            TipoEquipoProcs = new HashSet<TipoEquipoProc>();
        }

        public string Procedimiento1 { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? DescripcionLarg { get; set; }
        public string? Referencia { get; set; }
        public string TipoProcedimiento { get; set; } = null!;
        public string Aprobado { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal HorasEstCrono { get; set; }
        public decimal HorasEstAgre { get; set; }
        public decimal PeriodicidadDias { get; set; }
        public string? ProcAnterior { get; set; }
        public string? VersionAnterior { get; set; }
        public string? ProcAlterno { get; set; }
        public string? VersionAlterna { get; set; }
        public DateTime? FechaElaborado { get; set; }
        public string? ElaboradoPor { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaHoraCreacio { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaHoraAprobac { get; set; }
        public string? UsuarioHisto { get; set; }
        public DateTime? FechaHoraHisto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Procedimiento? Procedimiento2 { get; set; }
        public virtual Procedimiento? ProcedimientoNavigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioHistoNavigation { get; set; }
        public virtual ProcNota ProcNota { get; set; } = null!;
        public virtual ICollection<DocsProcedim> DocsProcedims { get; set; }
        public virtual ICollection<Procedimiento> InverseProcedimiento2 { get; set; }
        public virtual ICollection<Procedimiento> InverseProcedimientoNavigation { get; set; }
        public virtual ICollection<OtDetalle> OtDetalles { get; set; }
        public virtual ICollection<ProcArticulo> ProcArticulos { get; set; }
        public virtual ICollection<ProcEqPreventMed> ProcEqPreventMeds { get; set; }
        public virtual ICollection<ProcEqPrevent> ProcEqPrevents { get; set; }
        public virtual ICollection<ProcEquipo> ProcEquipos { get; set; }
        public virtual ICollection<ProcPuesto> ProcPuestos { get; set; }
        public virtual ICollection<TipoEquipoProc> TipoEquipoProcs { get; set; }
    }
}
