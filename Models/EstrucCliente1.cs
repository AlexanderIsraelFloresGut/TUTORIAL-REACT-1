using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucCliente1
    {
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente1 ClienteNavigation { get; set; } = null!;
        public virtual EstrucManufactura1 EstrucManufactura1 { get; set; } = null!;
    }
}
