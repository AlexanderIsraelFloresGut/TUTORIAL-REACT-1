using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MultipleAdquiriente
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Adquiriente { get; set; } = null!;
        public decimal? Participacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Nit AdquirienteNavigation { get; set; } = null!;
    }
}
