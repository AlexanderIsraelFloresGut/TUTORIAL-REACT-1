using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EscalaBonif2
    {
        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public int Version { get; set; }
        public string Articulo { get; set; } = null!;
        public int EscalaBonif { get; set; }
        public int VersionBonif { get; set; }
        public string ArticuloBonif { get; set; } = null!;
        public int MinArtFact { get; set; }
        public int? MaxArtFact { get; set; }
        public decimal UnidadesBonif { get; set; }
        public DateTime FechaInicioEsc { get; set; }
        public DateTime FechaFinEsc { get; set; }
        public decimal? FactorBonif { get; set; }
        public DateTime? FechaUltModif { get; set; }
        public string? UsuarioUltModif { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloBonifNavigation { get; set; } = null!;
        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual VersionNivel2 VersionNivel2 { get; set; } = null!;
    }
}
