using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoIndicePrecio1
    {
        public TipoIndicePrecio1()
        {
            ActivoDesmantelamiento1TipoIndicePrecioFNavigations = new HashSet<ActivoDesmantelamiento1>();
            ActivoDesmantelamiento1TipoIndicePrecioNavigations = new HashSet<ActivoDesmantelamiento1>();
            ActivoMejora1TipoIndicePrecioCNavigations = new HashSet<ActivoMejora1>();
            ActivoMejora1TipoIndicePrecioNavigations = new HashSet<ActivoMejora1>();
            IndicePrecio1s = new HashSet<IndicePrecio1>();
            TipoActivo1IndRevComp1Navigations = new HashSet<TipoActivo1>();
            TipoActivo1IndRevComp2Navigations = new HashSet<TipoActivo1>();
            TipoActivo1IndRevComp3Navigations = new HashSet<TipoActivo1>();
            TipoActivo1TipoIndicePrecioCNavigations = new HashSet<TipoActivo1>();
            TipoActivo1TipoIndicePrecioNavigations = new HashSet<TipoActivo1>();
        }

        public string TipoIndicePrecio { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoDesmantelamiento1> ActivoDesmantelamiento1TipoIndicePrecioFNavigations { get; set; }
        public virtual ICollection<ActivoDesmantelamiento1> ActivoDesmantelamiento1TipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<ActivoMejora1> ActivoMejora1TipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<ActivoMejora1> ActivoMejora1TipoIndicePrecioNavigations { get; set; }
        public virtual ICollection<IndicePrecio1> IndicePrecio1s { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1IndRevComp1Navigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1IndRevComp2Navigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1IndRevComp3Navigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1TipoIndicePrecioCNavigations { get; set; }
        public virtual ICollection<TipoActivo1> TipoActivo1TipoIndicePrecioNavigations { get; set; }
    }
}
