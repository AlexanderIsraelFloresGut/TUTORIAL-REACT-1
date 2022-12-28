using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClienteVendedor2
    {
        public string Cliente { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
        public virtual Vendedor2 VendedorNavigation { get; set; } = null!;
    }
}
