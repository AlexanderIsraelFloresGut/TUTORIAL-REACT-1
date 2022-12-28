using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GrupoConcepto2
    {
        public GrupoConcepto2()
        {
            GrupoConceptoDet2s = new HashSet<GrupoConceptoDet2>();
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

        public virtual ICollection<GrupoConceptoDet2> GrupoConceptoDet2s { get; set; }
    }
}
