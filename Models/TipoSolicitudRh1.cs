using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoSolicitudRh1
    {
        public TipoSolicitudRh1()
        {
            SolicitudRh1s = new HashSet<SolicitudRh1>();
            TipSolRhUsuario1s = new HashSet<TipSolRhUsuario1>();
            TipoSoliRhNotif1s = new HashSet<TipoSoliRhNotif1>();
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

        public virtual EstadoEmpleado1? EstadoEmpleadoNavigation { get; set; }
        public virtual TipoAccion1? TipoAccionNavigation { get; set; }
        public virtual TipoAusencium1? TipoAusenciaNavigation { get; set; }
        public virtual ICollection<SolicitudRh1> SolicitudRh1s { get; set; }
        public virtual ICollection<TipSolRhUsuario1> TipSolRhUsuario1s { get; set; }
        public virtual ICollection<TipoSoliRhNotif1> TipoSoliRhNotif1s { get; set; }
    }
}
