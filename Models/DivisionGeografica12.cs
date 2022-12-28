using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica12
    {
        public DivisionGeografica12()
        {
            Cotizante2s = new HashSet<Cotizante2>();
            DivisionGeografica22s = new HashSet<DivisionGeografica22>();
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

        public virtual Pai2 PaisNavigation { get; set; } = null!;
        public virtual ICollection<Cotizante2> Cotizante2s { get; set; }
        public virtual ICollection<DivisionGeografica22> DivisionGeografica22s { get; set; }
    }
}
