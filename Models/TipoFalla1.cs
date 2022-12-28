using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoFalla1
    {
        public TipoFalla1()
        {
            OtDetalle1s = new HashSet<OtDetalle1>();
        }

        public string TipoFalla { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OtDetalle1> OtDetalle1s { get; set; }
    }
}
