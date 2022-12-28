using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Ratio1
    {
        public Ratio1()
        {
            RatiosCuenta1s = new HashSet<RatiosCuenta1>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<RatiosCuenta1> RatiosCuenta1s { get; set; }
    }
}
