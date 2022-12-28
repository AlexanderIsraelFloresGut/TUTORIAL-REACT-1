using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenAsocReserva2
    {
        public string Orden { get; set; } = null!;
        public string Componente { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string? BodegaMp { get; set; }
        public string Operacion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
