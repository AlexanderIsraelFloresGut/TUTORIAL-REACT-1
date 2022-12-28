using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenCliente
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual OrdenProduccion OrdenProduccionNavigation { get; set; } = null!;
    }
}
