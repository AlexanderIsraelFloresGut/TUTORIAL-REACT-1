using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoIndicePrecio2
    {
        public TipoIndicePrecio2()
        {
            ActivoDesmantelamiento2TipoIndicePrecioFNavigations = new HashSet<ActivoDesmantelamiento2>();
            ActivoDesmantelamiento2TipoIndicePrecioNavigations = new HashSet<ActivoDesmantelamiento2>();
            ActivoMejora2TipoIndicePrecioCNavigations = new HashSet<ActivoMejora2>();
            ActivoMejora2TipoIndicePrecioNavigations = new HashSet<ActivoMejora2>();
            IndicePrecio2s = new HashSet<IndicePrecio2>();
            TipoActivo2IndRevComp1Navigations = new HashSet<TipoActivo2>();
            TipoActivo2IndRevComp2Navigations = new HashSet<TipoActivo2>();
            TipoActivo2IndRevComp3Navigations = new HashSet<TipoActivo2>();
            TipoActivo2TipoIndicePrecioCNavigations = new HashSet<TipoActivo2>();
            TipoActivo2TipoIndicePrecioNavigations = new HashSet<TipoActivo2>();
        }

        public string TipoIndicePrecio { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoDesmantelamiento2> ActivoDesmantelamiento2TipoIndicePrecioFNavigations { get; set; }
        public virtual ICollection<ActivoDesmantelamiento2> ActivoDesmantelamiento2TipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<ActivoMejora2> ActivoMejora2TipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<ActivoMejora2> ActivoMejora2TipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<IndicePrecio2> IndicePrecio2s { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2IndRevComp1Navigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2IndRevComp2Navigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2IndRevComp3Navigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2TipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<TipoActivo2> TipoActivo2TipoIndicePrecioNavigations { get; set; }
    }
}
