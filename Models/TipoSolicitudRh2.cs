using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoSolicitudRh2
    {
        public TipoSolicitudRh2()
        {
            SolicitudRh2s = new HashSet<SolicitudRh2>();
            TipSolRhUsuario2s = new HashSet<TipSolRhUsuario2>();
            TipoSoliRhNotif2s = new HashSet<TipoSoliRhNotif2>();
        }

        public string TipoSolicitudRh { get; set; } = null!;
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

        public virtual EstadoEmpleado2? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoAccion2? TipoAccionNavigation { get; set; }
        public virtual TipoAusencium2? TipoAusenciaNavigation { get; set; }
        public virtual ICollection<SolicitudRh2> SolicitudRh2s { get; set; }
        public virtual ICollection<TipSolRhUsuario2> TipSolRhUsuario2s { get; set; }
        public virtual ICollection<TipoSoliRhNotif2> TipoSoliRhNotif2s { get; set; }
    }
}
