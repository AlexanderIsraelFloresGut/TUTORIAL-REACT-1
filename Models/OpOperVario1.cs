using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperVario1
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Descripcion { get; set; }
        public string Tipo { get; set; } = null!;
        public string Contabilizada { get; set; } = null!;
        public decimal CostoLocal { get; set; }
        public decimal CostoDolar { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaTransaccion { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Asiento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperacion1 O { get; set; } = null!;
    }
}
