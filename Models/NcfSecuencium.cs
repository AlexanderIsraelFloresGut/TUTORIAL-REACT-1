using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NcfSecuencium
    {
        public string Prefijo { get; set; } = null!;
        public int Secuencia { get; set; }
        public string SecuenciaInicial { get; set; } = null!;
        public string SecuenciaFinal { get; set; } = null!;
        public DateTime FechaVence { get; set; }
        public string? UltimoValor { get; set; }
        public string? Descripcion { get; set; }
        public string Estado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
