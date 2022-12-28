using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoOperacion2
    {
        public TipoOperacion2()
        {
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            MatrizOperInventario2s = new HashSet<MatrizOperInventario2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public string TipoOperacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<MatrizOperInventario2> MatrizOperInventario2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
