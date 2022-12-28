using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodIngreso
    {
        public CodIngreso()
        {
            Retenciones = new HashSet<Retencione>();
        }

        public string CodIngreso1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Gravado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CodingCartaRentum CodingCartaRentum { get; set; } = null!;
        public virtual ICollection<Retencione> Retenciones { get; set; }
    }
}
