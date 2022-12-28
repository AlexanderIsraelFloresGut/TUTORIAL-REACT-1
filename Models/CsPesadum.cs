using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsPesadum
    {
        public long Id { get; set; }
        public int Pesada { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal Peso { get; set; }
        public int? Caja { get; set; }
        public string? Cliente { get; set; }
        public string OrdenCompra { get; set; } = null!;
        public int? Termo { get; set; }
        public string? ProductoTerminado { get; set; }
        public int? EnProduccion { get; set; }
        public decimal Rechazo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
