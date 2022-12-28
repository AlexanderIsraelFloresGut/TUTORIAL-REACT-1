using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Requisicion2
    {
        public Requisicion2()
        {
            RequisicionLinea2s = new HashSet<RequisicionLinea2>();
        }

        public string Requisicion { get; set; } = null!;
        public string OrdenProduccion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenProduccion2 OrdenProduccionNavigation { get; set; } = null!;
        public virtual ICollection<RequisicionLinea2> RequisicionLinea2s { get; set; }
    }
}
