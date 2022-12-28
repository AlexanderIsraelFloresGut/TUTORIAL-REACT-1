using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MrpPlanificador
    {
        public string PdrmrcCodesc { get; set; } = null!;
        public int PdrmrcNrolot { get; set; }
        public int PdrmrcNroitm { get; set; }
        public string? PdrmrcTippro { get; set; }
        public string? PdrmrcArtcod { get; set; }
        public int? PdrmrcNrofor { get; set; }
        public decimal? PdrmrcCantid { get; set; }
        public DateTime? PdrmrcFecalt { get; set; }
        public int? PdrmrcItmmri { get; set; }
        public string? PdrmrcNrocpv { get; set; }
        public string Procesado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
