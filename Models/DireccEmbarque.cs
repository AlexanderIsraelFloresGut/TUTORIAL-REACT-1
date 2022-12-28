using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DireccEmbarque
    {
        public string Cliente { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? DetalleDireccion { get; set; }
        public string? Descripcion { get; set; }
        public string? Contacto { get; set; }
        public string? Cargo { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual DetalleDireccion? DetalleDireccionNavigation { get; set; }
    }
}
