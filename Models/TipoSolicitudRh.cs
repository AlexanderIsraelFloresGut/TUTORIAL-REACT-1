using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoSolicitudRh
    {
        public TipoSolicitudRh()
        {
            SolicitudRhs = new HashSet<SolicitudRh>();
            TipSolRhUsuarios = new HashSet<TipSolRhUsuario>();
            TipoSoliRhNotifs = new HashSet<TipoSoliRhNotif>();
        }

        public string TipoSolicitudRh1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? TipoAccion { get; set; }
        public string? EstadoEmpleado { get; set; }
        public string? TipoAusencia { get; set; }
        public string ApruebaSuperior { get; set; } = null!;
        public short? NivelAprobacion { get; set; }
        public short? DiasParaEscalar { get; set; }
        public short? DiasParaVencer { get; set; }
        public string? MultiSuperiores { get; set; }
        public string AprobFinalRh { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? AccesoDirecto { get; set; }
        public string? DescAcceso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstadoEmpleado? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoAccion? TipoAccionNavigation { get; set; }
        public virtual TipoAusencium? TipoAusenciaNavigation { get; set; }
        public virtual ICollection<SolicitudRh> SolicitudRhs { get; set; }
        public virtual ICollection<TipSolRhUsuario> TipSolRhUsuarios { get; set; }
        public virtual ICollection<TipoSoliRhNotif> TipoSoliRhNotifs { get; set; }
    }
}
