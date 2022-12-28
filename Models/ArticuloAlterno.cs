using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloAlterno
    {
        public string Articulo { get; set; } = null!;
        public string Alterno { get; set; } = null!;
        public short Prioridad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo AlternoNavigation { get; set; } = null!;
        public virtual Articulo ArticuloNavigation { get; set; } = null!;
    }
}
