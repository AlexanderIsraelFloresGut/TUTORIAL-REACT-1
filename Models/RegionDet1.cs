using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RegionDet1
    {
        public string Region { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual Region1 RegionNavigation { get; set; } = null!;
    }
}
