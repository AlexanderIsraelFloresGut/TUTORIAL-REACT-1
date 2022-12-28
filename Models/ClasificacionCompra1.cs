using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionCompra1
    {
        public string Codigo { get; set; } = null!;
        public string CodigoClasificacion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Clasificacion1 CodigoClasificacionNavigation { get; set; } = null!;
        public virtual AutorCompra1 CodigoNavigation { get; set; } = null!;
    }
}
