using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BonifArtXCli1
    {
        public string Cliente { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public int EscalaBonif { get; set; }
        public int VersionBonif { get; set; }
        public int CantidadInicial { get; set; }
        public int CantidadFinal { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal? FactorBonif { get; set; }
        public string ArticuloBonif { get; set; } = null!;
        public decimal UnidadesBonif { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
