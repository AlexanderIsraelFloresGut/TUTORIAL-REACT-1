using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RequisicionLinea1
    {
        public string Requisicion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public decimal CantSolicitada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Requisicion1 RequisicionNavigation { get; set; } = null!;
    }
}
