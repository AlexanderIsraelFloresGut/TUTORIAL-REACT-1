using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PistaExistencium
    {
        public PistaExistencium()
        {
            PistaExistenDets = new HashSet<PistaExistenDet>();
        }

        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string? Referencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<PistaExistenDet> PistaExistenDets { get; set; }
    }
}
