using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EscalaDcto1
    {
        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public int Version { get; set; }
        public string Articulo { get; set; } = null!;
        public int EscalaDcto { get; set; }
        public int VersionDcto { get; set; }
        public int? MinUnidFact { get; set; }
        public int? MaxUnidFact { get; set; }
        public decimal PorcDcto { get; set; }
        public DateTime FechaInicioEsc { get; set; }
        public DateTime FechaFinEsc { get; set; }
        public DateTime? FechaUltModif { get; set; }
        public string? UsuarioUltModif { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual VersionNivel1 VersionNivel1 { get; set; } = null!;
    }
}
