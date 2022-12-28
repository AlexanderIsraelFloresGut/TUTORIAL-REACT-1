using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PaqueteInventario1
    {
        public PaqueteInventario1()
        {
            DocumentoInv1s = new HashSet<DocumentoInv1>();
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
        public virtual ICollection<DocumentoInv1> DocumentoInv1s { get; set; }
    }
}
