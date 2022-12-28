using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VModulo
    {
        public string? Modulo { get; set; }
        public string NombreModulo { get; set; } = null!;
        public string EsEstandar { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
    }
}
