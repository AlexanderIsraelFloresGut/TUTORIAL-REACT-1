using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Preferencium1
    {
        public string Usuario { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string Opcion { get; set; } = null!;
        public string? Preferencia1 { get; set; }
        public string? Preferencia2 { get; set; }
        public string? Preferencia3 { get; set; }
        public string? Preferencia4 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
