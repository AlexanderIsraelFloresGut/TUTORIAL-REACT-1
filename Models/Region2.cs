using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Region2
    {
        public Region2()
        {
            RegionDet2s = new HashSet<RegionDet2>();
        }

        public string Region { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<RegionDet2> RegionDet2s { get; set; }
    }
}
