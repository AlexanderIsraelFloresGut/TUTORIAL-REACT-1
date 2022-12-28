using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoNit2
    {
        public TipoNit2()
        {
            Nit2s = new HashSet<Nit2>();
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

        public virtual ICollection<Nit2> Nit2s { get; set; }
    }
}
