using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica1
    {
        public DivisionGeografica1()
        {
            Cotizantes = new HashSet<Cotizante>();
            DivisionGeografica2s = new HashSet<DivisionGeografica2>();
        }

        public string Pais { get; set; } = null!;
        public string DivisionGeografica11 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Pai PaisNavigation { get; set; } = null!;
        public virtual ICollection<Cotizante> Cotizantes { get; set; }
        public virtual ICollection<DivisionGeografica2> DivisionGeografica2s { get; set; }
    }
}
