using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Favorito
    {
        public int Accion { get; set; }
        public string Usuario { get; set; } = null!;
        public int? Posicion { get; set; }
        public int AccionModulo { get; set; }
        public int Padre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
