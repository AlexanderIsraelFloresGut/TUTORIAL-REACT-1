using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpPronostico1
    {
        public SpPronostico1()
        {
            SpPronosticoDetalle1s = new HashSet<SpPronosticoDetalle1>();
        }

        public string Pronostico { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime PdoIniPronost { get; set; }
        public DateTime PdoFinPronost { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<SpPronosticoDetalle1> SpPronosticoDetalle1s { get; set; }
    }
}
