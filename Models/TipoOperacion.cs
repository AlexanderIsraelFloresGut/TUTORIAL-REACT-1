using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoOperacion
    {
        public TipoOperacion()
        {
            LineaDocInvs = new HashSet<LineaDocInv>();
            MatrizOperInventarios = new HashSet<MatrizOperInventario>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string TipoOperacion1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<MatrizOperInventario> MatrizOperInventarios { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
