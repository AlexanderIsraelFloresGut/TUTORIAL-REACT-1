using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModeloRetencion2
    {
        public ModeloRetencion2()
        {
            Articulo2s = new HashSet<Articulo2>();
            Cliente2s = new HashSet<Cliente2>();
            ConceptoVale2s = new HashSet<ConceptoVale2>();
            Proveedor2s = new HashSet<Proveedor2>();
            Regimene2s = new HashSet<Regimene2>();
        }

        public string ModeloRetencion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<ConceptoVale2> ConceptoVale2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
        public virtual ICollection<Regimene2> Regimene2s { get; set; }
    }
}
