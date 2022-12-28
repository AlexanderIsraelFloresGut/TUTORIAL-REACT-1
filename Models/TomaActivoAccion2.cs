using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TomaActivoAccion2
    {
        public string ActivoFijo { get; set; } = null!;
        public string ActivoObservacion { get; set; } = null!;
        public string? NuevoValor { get; set; }
        public int? Firme { get; set; }
        public string? TipoAccion { get; set; }
        public string? PocketId { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TomaActivoObserv2 ActivoObservacionNavigation { get; set; } = null!;
    }
}
