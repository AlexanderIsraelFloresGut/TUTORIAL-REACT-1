using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoFijo2
    {
        public ActivoFijo2()
        {
            ActivoAccion2s = new HashSet<ActivoAccion2>();
            ActivoCentro2s = new HashSet<ActivoCentro2>();
            ActivoHistMant2s = new HashSet<ActivoHistMant2>();
            ActivoMejora2s = new HashSet<ActivoMejora2>();
            Caja2s = new HashSet<Caja2>();
            DetSolicitudAfNotif2s = new HashSet<DetSolicitudAfNotif2>();
        }

        public string ActivoFijo { get; set; } = null!;
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

        public virtual EstadoActivo2? EstadoActivoNavigation { get; set; }
        public virtual TipoActivo2 TipoActivoNavigation { get; set; } = null!;
        public virtual Ubicacion2? UbicacionNavigation { get; set; }
        public virtual ICollection<ActivoAccion2> ActivoAccion2s { get; set; }
        public virtual ICollection<ActivoCentro2> ActivoCentro2s { get; set; }
        public virtual ICollection<ActivoHistMant2> ActivoHistMant2s { get; set; }
        public virtual ICollection<ActivoMejora2> ActivoMejora2s { get; set; }
        public virtual ICollection<Caja2> Caja2s { get; set; }
        public virtual ICollection<DetSolicitudAfNotif2> DetSolicitudAfNotif2s { get; set; }
    }
}
