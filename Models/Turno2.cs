using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Turno2
    {
        public Turno2()
        {
            OpOperDet2s = new HashSet<OpOperDet2>();
        }

        public short Turno { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public decimal Duracion { get; set; }
        public decimal MinutosNoproduc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OpOperDet2> OpOperDet2s { get; set; }
    }
}
