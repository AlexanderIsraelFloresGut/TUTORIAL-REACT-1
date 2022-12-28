using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Autenticacion
    {
        public Autenticacion()
        {
            AutenticaCatalogos = new HashSet<AutenticaCatalogo>();
        }

        public string Codigo { get; set; } = null!;
        public string? UsuarioExactus { get; set; }
        public string? UsuarioWindows { get; set; }
        public string? Clave { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2? UsuarioExactusNavigation { get; set; }
        public virtual ICollection<AutenticaCatalogo> AutenticaCatalogos { get; set; }
    }
}
