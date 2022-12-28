using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ContactoCliente2
    {
        public string Cliente { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string? Departamento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; }
        public string? Fax { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
    }
}
