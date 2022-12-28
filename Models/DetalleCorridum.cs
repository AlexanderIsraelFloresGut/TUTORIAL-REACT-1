using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleCorridum
    {
        public int CorridaAd { get; set; }
        public string AsientoDistribuid { get; set; } = null!;
        public string? AsientoFiscal { get; set; }
        public string? AsientoCorp { get; set; }
        public short? Consecutivo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AsientoDistribuid AsientoDistribu { get; set; } = null!;
        public virtual CorridaAd CorridaAdNavigation { get; set; } = null!;
    }
}
