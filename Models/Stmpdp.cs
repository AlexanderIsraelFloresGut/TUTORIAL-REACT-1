using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Stmpdp
    {
        public string StmpdpTippro { get; set; } = null!;
        public string StmpdpArtcod { get; set; } = null!;
        public int StmpdpNroitm { get; set; }
        public string? StmpdpNrocta { get; set; }
        public short? StmpdpOrdpri { get; set; }
        public string? StmpdpUnifco { get; set; }
        public decimal? StmpdpFacfco { get; set; }
        public short? StmpdpDiaent { get; set; }
        public string? StmpdpTipfor { get; set; }
        public string? StmpdpArtfor { get; set; }
        public string? StmpdpFormul { get; set; }
        public string? StmpdpNormar { get; set; }
        public short? StmpdpDiapre { get; set; }
        public decimal? StmpdpMinimo { get; set; }
        public decimal? StmpdpMaximo { get; set; }
        public decimal? StmpdpCntfij { get; set; }
        public string? StmpdpCadenc { get; set; }
        public short? StmpdpDiafi1 { get; set; }
        public short? StmpdpDiafi2 { get; set; }
        public string? StmpdpDiadom { get; set; }
        public string? StmpdpDialun { get; set; }
        public string? StmpdpDiamar { get; set; }
        public string? StmpdpDiamie { get; set; }
        public string? StmpdpDiajue { get; set; }
        public string? StmpdpDiavie { get; set; }
        public string? StmpdpDiasab { get; set; }
        public string? StmpdpRutfab { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
