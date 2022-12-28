using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoOperacion1
    {
        public TipoOperacion1()
        {
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            MatrizOperInventario1s = new HashSet<MatrizOperInventario1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
        }

        public string TipoOperacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<MatrizOperInventario1> MatrizOperInventario1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
