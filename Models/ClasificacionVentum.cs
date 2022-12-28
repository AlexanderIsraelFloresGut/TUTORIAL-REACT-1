using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionVentum
    {
        public string Codigo { get; set; } = null!;
        public string CodigoArticulo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo CodigoArticuloNavigation { get; set; } = null!;
        public virtual AutorVentum CodigoNavigation { get; set; } = null!;
    }
}
