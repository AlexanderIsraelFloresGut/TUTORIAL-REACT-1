using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteRemolque
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? SubTipoRem { get; set; }
        public string? Placa { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteSubtipoRem? SubTipoRemNavigation { get; set; }
    }
}
