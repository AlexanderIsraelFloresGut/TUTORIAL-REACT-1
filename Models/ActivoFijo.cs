using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoFijo
    {
        public ActivoFijo()
        {
            ActivoAccions = new HashSet<ActivoAccion>();
            ActivoCentros = new HashSet<ActivoCentro>();
            ActivoHistMants = new HashSet<ActivoHistMant>();
            ActivoMejoras = new HashSet<ActivoMejora>();
            Cajas = new HashSet<Caja>();
            DetSolicitudAfNotifs = new HashSet<DetSolicitudAfNotif>();
        }

        public string ActivoFijo1 { get; set; } = null!;
        public string? EstadoActivo { get; set; }
        public string? Ubicacion { get; set; }
        public string TipoActivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaUltMant { get; set; }
        public DateTime? FechaProxMant { get; set; }
        public decimal? TasaDepreciacionF { get; set; }
        public decimal? TasaDepreciacionC { get; set; }
        public string? Clasificacion { get; set; }
        public string UsaComponente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstadoActivo? EstadoActivoNavigation { get; set; }
        public virtual TipoActivo TipoActivoNavigation { get; set; } = null!;
        public virtual Ubicacion? UbicacionNavigation { get; set; }
        public virtual ICollection<ActivoAccion> ActivoAccions { get; set; }
        public virtual ICollection<ActivoCentro> ActivoCentros { get; set; }
        public virtual ICollection<ActivoHistMant> ActivoHistMants { get; set; }
        public virtual ICollection<ActivoMejora> ActivoMejoras { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<DetSolicitudAfNotif> DetSolicitudAfNotifs { get; set; }
    }
}
