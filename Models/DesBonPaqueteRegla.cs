using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonPaqueteRegla
    {
        public string Paquete { get; set; } = null!;
        public string Regla { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DesBonPaquete PaqueteNavigation { get; set; } = null!;
        public virtual DesBonRegla ReglaNavigation { get; set; } = null!;
    }
}
