using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica11
    {
        public DivisionGeografica11()
        {
            Cotizante1s = new HashSet<Cotizante1>();
            DivisionGeografica21s = new HashSet<DivisionGeografica21>();
        }

        public string Pais { get; set; } = null!;
        public string DivisionGeografica1 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual ICollection<Cotizante1> Cotizante1s { get; set; }
        public virtual ICollection<DivisionGeografica21> DivisionGeografica21s { get; set; }
    }
}
