using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodIngreso1
    {
        public CodIngreso1()
        {
            Retencione1s = new HashSet<Retencione1>();
        }

        public string CodIngreso { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Gravado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CodingCartaRentum1 CodingCartaRentum1 { get; set; } = null!;
        public virtual ICollection<Retencione1> Retencione1s { get; set; }
    }
}
