using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Procedimiento1
    {
        public Procedimiento1()
        {
            DocsProcedim1s = new HashSet<DocsProcedim1>();
            InverseProcedimiento11 = new HashSet<Procedimiento1>();
            InverseProcedimiento1Navigation = new HashSet<Procedimiento1>();
            OtDetalle1s = new HashSet<OtDetalle1>();
            ProcArticulo1s = new HashSet<ProcArticulo1>();
            ProcEqPrevent1s = new HashSet<ProcEqPrevent1>();
            ProcEqPreventMed1s = new HashSet<ProcEqPreventMed1>();
            ProcEquipo1s = new HashSet<ProcEquipo1>();
            ProcPuesto1s = new HashSet<ProcPuesto1>();
            TipoEquipoProc1s = new HashSet<TipoEquipoProc1>();
        }

        public string Procedimiento { get; set; } = null!;
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

        public virtual Procedimiento1? Procedimiento11 { get; set; }
        public virtual Procedimiento1? Procedimiento1Navigation { get; set; }
        public virtual Usuario2? UsuarioAprobacionNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioHistoNavigation { get; set; }
        public virtual ProcNota1 ProcNota1 { get; set; } = null!;
        public virtual ICollection<DocsProcedim1> DocsProcedim1s { get; set; }
        public virtual ICollection<Procedimiento1> InverseProcedimiento11 { get; set; }
        public virtual ICollection<Procedimiento1> InverseProcedimiento1Navigation { get; set; }
        public virtual ICollection<OtDetalle1> OtDetalle1s { get; set; }
        public virtual ICollection<ProcArticulo1> ProcArticulo1s { get; set; }
        public virtual ICollection<ProcEqPrevent1> ProcEqPrevent1s { get; set; }
        public virtual ICollection<ProcEqPreventMed1> ProcEqPreventMed1s { get; set; }
        public virtual ICollection<ProcEquipo1> ProcEquipo1s { get; set; }
        public virtual ICollection<ProcPuesto1> ProcPuesto1s { get; set; }
        public virtual ICollection<TipoEquipoProc1> TipoEquipoProc1s { get; set; }
    }
}
