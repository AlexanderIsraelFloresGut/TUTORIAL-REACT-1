using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TmpOpOperDetMo
    {
        public DateTime FechaHoraProduc { get; set; }
        public int NumLinea { get; set; }
        public string TipoManoObra { get; set; } = null!;
        public decimal CantHoras { get; set; }
        public string ClasificacionNombre { get; set; } = null!;
        public string ClasificacionValue { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
