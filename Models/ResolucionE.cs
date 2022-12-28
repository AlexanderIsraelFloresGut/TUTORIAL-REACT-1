using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ResolucionE
    {
        public string Resolucion { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string? Estado { get; set; }
        public string Serie { get; set; } = null!;
        public string Autorizacion { get; set; } = null!;
        public string DocInicial { get; set; } = null!;
        public string DocFinal { get; set; } = null!;
        public string? UsuarioUltMod { get; set; }
        public DateTime? FechaUltMod { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Nit NitNavigation { get; set; } = null!;
        public virtual SubtipoDocCp SubtipoDocCp { get; set; } = null!;
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
    }
}
