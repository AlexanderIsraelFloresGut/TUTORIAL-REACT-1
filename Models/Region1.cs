using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Region1
    {
        public Region1()
        {
            RegionDet1s = new HashSet<RegionDet1>();
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

        public virtual ICollection<RegionDet1> RegionDet1s { get; set; }
    }
}
