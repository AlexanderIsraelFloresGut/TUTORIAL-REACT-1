using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ImpuestoAdicional
    {
        public string Clasificacion { get; set; } = null!;
        public string CodigoValor { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string DescAfectaImpuesto { get; set; } = null!;
        public string TipoImpuesto { get; set; } = null!;
        public decimal Impuesto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string ImpuestoIncluido { get; set; } = null!;
    }
}
