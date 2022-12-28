using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Requisicion1
    {
        public Requisicion1()
        {
            RequisicionLinea1s = new HashSet<RequisicionLinea1>();
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

        public virtual OrdenProduccion1 OrdenProduccionNavigation { get; set; } = null!;
        public virtual ICollection<RequisicionLinea1> RequisicionLinea1s { get; set; }
    }
}
