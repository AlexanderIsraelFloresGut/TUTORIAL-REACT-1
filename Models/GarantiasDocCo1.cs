using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GarantiasDocCo1
    {
        public string GarantiaId { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? TipoGarantia { get; set; }
        public string? DescGarantia { get; set; }
        public string? ObsGarantia { get; set; }
        public string? ArtGarantia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1? ArtGarantiaNavigation { get; set; }
        public virtual DocumentoEmbarque1 DocumentoEmbarque1 { get; set; } = null!;
    }
}
