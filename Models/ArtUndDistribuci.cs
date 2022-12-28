using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArtUndDistribuci
    {
        public string Articulo { get; set; } = null!;
        public string UndDistribucion { get; set; } = null!;
        public decimal FactorConversion { get; set; }
        public string CodigoBarras { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum UndDistribucionNavigation { get; set; } = null!;
    }
}
