using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BodCargaManuf
    {
        public string Bodega { get; set; } = null!;
        public string UtilizaManuf { get; set; } = null!;
        public string? Modulo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega BodegaNavigation { get; set; } = null!;
    }
}
