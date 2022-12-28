using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BitacoraProceso
    {
        public int LlaveBitProceso { get; set; }
        public string Usuario { get; set; } = null!;
        public string Compania { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Estacion { get; set; } = null!;
        public string Proceso { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
