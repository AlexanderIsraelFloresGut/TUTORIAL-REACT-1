using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AutenticaCatalogo
    {
        public string Codigo { get; set; } = null!;
        public string Catalogo { get; set; } = null!;
        public string Conjunto { get; set; } = null!;
        public string CodigoCatalogo { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string? UsuarioPrivilegios { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Autenticacion CodigoNavigation { get; set; } = null!;
        public virtual Conjunto ConjuntoNavigation { get; set; } = null!;
    }
}
