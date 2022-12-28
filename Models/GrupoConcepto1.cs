using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GrupoConcepto1
    {
        public GrupoConcepto1()
        {
            GrupoConceptoDet1s = new HashSet<GrupoConceptoDet1>();
        }

        public string GrupoConcepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<GrupoConceptoDet1> GrupoConceptoDet1s { get; set; }
    }
}
