using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsSerie1
    {
        public string? Origen { get; set; }
        public DateTime Fecha { get; set; }
        public string Serie { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Bodega { get; set; }
        public int? Cajas { get; set; }
        public decimal? Lbs { get; set; }
        public string? Pedido { get; set; }
        public string? Estado { get; set; }
        public string? EsFresco { get; set; }
        public decimal? Pesoneto { get; set; }
        public decimal? Pesoreal { get; set; }
        public int? NoCaja { get; set; }
        public decimal? NoPeces { get; set; }
        public string? Cliente { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
