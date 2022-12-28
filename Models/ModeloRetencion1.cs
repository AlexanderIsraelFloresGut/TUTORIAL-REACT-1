using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModeloRetencion1
    {
        public ModeloRetencion1()
        {
            Articulo1s = new HashSet<Articulo1>();
            Cliente1s = new HashSet<Cliente1>();
            ConceptoVale1s = new HashSet<ConceptoVale1>();
            Proveedor1s = new HashSet<Proveedor1>();
            Regimene1s = new HashSet<Regimene1>();
        }

        public string ModeloRetencion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<ConceptoVale1> ConceptoVale1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
        public virtual ICollection<Regimene1> Regimene1s { get; set; }
    }
}
