using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoNit1
    {
        public TipoNit1()
        {
            Nit1s = new HashSet<Nit1>();
        }

        public string Tipo { get; set; } = null!;
        public string Mascara { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Descripcion { get; set; }
        public string? UTipoDocumentoIdentidad { get; set; }

        public virtual ICollection<Nit1> Nit1s { get; set; }
    }
}
