using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoCotizante
    {
        public SubtipoCotizante()
        {
            Cotizantes = new HashSet<Cotizante>();
        }

        public string SubtipoCotizante1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cotizante> Cotizantes { get; set; }
    }
}
