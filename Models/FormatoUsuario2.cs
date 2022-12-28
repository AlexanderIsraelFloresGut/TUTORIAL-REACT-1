using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoUsuario2
    {
        public string Formato { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? ModificarFormato { get; set; }
        public string GenerarReporte { get; set; } = null!;
        public string ModificarFiltro { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Formato2 FormatoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
