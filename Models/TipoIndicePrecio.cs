using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoIndicePrecio
    {
        public TipoIndicePrecio()
        {
            ActivoDesmantelamientoTipoIndicePrecioFNavigations = new HashSet<ActivoDesmantelamiento>();
            ActivoDesmantelamientoTipoIndicePrecioNavigations = new HashSet<ActivoDesmantelamiento>();
            ActivoMejoraTipoIndicePrecioCNavigations = new HashSet<ActivoMejora>();
            ActivoMejoraTipoIndicePrecioNavigations = new HashSet<ActivoMejora>();
            IndicePrecios = new HashSet<IndicePrecio>();
            TipoActivoIndRevComp1Navigations = new HashSet<TipoActivo>();
            TipoActivoIndRevComp2Navigations = new HashSet<TipoActivo>();
            TipoActivoIndRevComp3Navigations = new HashSet<TipoActivo>();
            TipoActivoTipoIndicePrecioCNavigations = new HashSet<TipoActivo>();
            TipoActivoTipoIndicePrecioNavigations = new HashSet<TipoActivo>();
        }

        public string TipoIndicePrecio1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoDesmantelamiento> ActivoDesmantelamientoTipoIndicePrecioFNavigations { get; set; }
        public virtual ICollection<ActivoDesmantelamiento> ActivoDesmantelamientoTipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<ActivoMejora> ActivoMejoraTipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<ActivoMejora> ActivoMejoraTipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<IndicePrecio> IndicePrecios { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoIndRevComp1Navigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoIndRevComp2Navigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoIndRevComp3Navigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoTipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<TipoActivo> TipoActivoTipoIndicePrecioNavigations { get; set; }
    }
}
