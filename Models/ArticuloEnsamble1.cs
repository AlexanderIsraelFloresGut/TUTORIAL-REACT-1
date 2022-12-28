using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloEnsamble1
    {
        public string ArticuloPadre { get; set; } = null!;
        public string ArticuloHijo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloHijoNavigation { get; set; } = null!;
        public virtual Articulo1 ArticuloPadreNavigation { get; set; } = null!;
    }
}
