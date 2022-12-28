using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VArtTallasColore
    {
        public string ArticuloPadre { get; set; } = null!;
        public string ArticuloHijo { get; set; } = null!;
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string Impuesto { get; set; } = null!;
        public decimal PrecioBaseLocal { get; set; }
        public decimal PrecioBaseDolar { get; set; }
        public string NivelPrecio { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public int Version { get; set; }
        public decimal Precio { get; set; }
        public int VersionArticulo { get; set; }
        public string Impuesto1Incluido { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
