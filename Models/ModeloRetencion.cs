using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModeloRetencion
    {
        public ModeloRetencion()
        {
            Articulos = new HashSet<Articulo>();
            Clientes = new HashSet<Cliente>();
            ConceptoVales = new HashSet<ConceptoVale>();
            Proveedors = new HashSet<Proveedor>();
            Regimenes = new HashSet<Regimene>();
        }

        public string ModeloRetencion1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ConceptoVale> ConceptoVales { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<Regimene> Regimenes { get; set; }
    }
}
