using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica31
    {
        public DivisionGeografica31()
        {
            DivisionGeografica41s = new HashSet<DivisionGeografica41>();
        }

        public string Pais { get; set; } = null!;
        public string DivisionGeografica1 { get; set; } = null!;
        public string DivisionGeografica2 { get; set; } = null!;
        public string DivisionGeografica3 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DivisionGeografica21 DivisionGeografica21 { get; set; } = null!;
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual ICollection<DivisionGeografica41> DivisionGeografica41s { get; set; }
    }
}
