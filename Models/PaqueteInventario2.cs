using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqueteInventario2
    {
        public PaqueteInventario2()
        {
            DocumentoInv2s = new HashSet<DocumentoInv2>();
        }

        public string PaqueteInventario { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string UltimoUsuario { get; set; } = null!;
        public string UsuarioCreador { get; set; } = null!;
        public DateTime FechaUltAcceso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreadorNavigation { get; set; } = null!;
        public virtual ICollection<DocumentoInv2> DocumentoInv2s { get; set; }
    }
}
