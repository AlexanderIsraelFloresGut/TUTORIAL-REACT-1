using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CostoUepsPep2
    {
        public string Articulo { get; set; } = null!;
        public DateTime Secuencia { get; set; }
        public decimal CantidadOriginal { get; set; }
        public decimal CantidadRestante { get; set; }
        public decimal CostoLocal { get; set; }
        public decimal CostoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
    }
}
