using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteMercancia
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public decimal? PesoBrutoTotal { get; set; }
        public string? UnidadPeso { get; set; }
        public decimal? PesoNetoTotal { get; set; }
        public int? NumTotalMercancias { get; set; }
        public decimal? CargoPorTasacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteUnidadPeso? UnidadPesoNavigation { get; set; }
    }
}
