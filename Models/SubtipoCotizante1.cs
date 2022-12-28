using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoCotizante1
    {
        public SubtipoCotizante1()
        {
            Cotizante1s = new HashSet<Cotizante1>();
        }

        public string SubtipoCotizante { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cotizante1> Cotizante1s { get; set; }
    }
}
