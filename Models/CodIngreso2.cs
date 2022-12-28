using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodIngreso2
    {
        public CodIngreso2()
        {
            Retencione2s = new HashSet<Retencione2>();
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

        public virtual CodingCartaRentum2 CodingCartaRentum2 { get; set; } = null!;
        public virtual ICollection<Retencione2> Retencione2s { get; set; }
    }
}
