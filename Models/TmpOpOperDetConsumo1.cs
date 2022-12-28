using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TmpOpOperDetConsumo1
    {
        public int NumLinea { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal CantidadConsumir { get; set; }
        public string ClasificacionNombre { get; set; } = null!;
        public string ClasificacionValue { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public string ArticuloDesc { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
