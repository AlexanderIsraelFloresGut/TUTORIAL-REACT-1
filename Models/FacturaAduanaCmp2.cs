using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FacturaAduanaCmp2
    {
        public string Proveedor { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public string? NumeroDua { get; set; }
        public DateTime? FechaDua { get; set; }
        public string? PartidaArancel { get; set; }
        public string? DescPartidaArancel { get; set; }
        public string? Aduana { get; set; }
        public string? NombreAgenAduana { get; set; }
        public string? ProveedorAdu { get; set; }
        public string? NitAgenAduana { get; set; }
        public decimal? ValorAduana { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
