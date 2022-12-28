using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VEncabezadoAsiento
    {
        public string Tabla { get; set; } = null!;
        public string Asiento { get; set; } = null!;
        public string TipoAsiento { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string ClaseAsiento { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime RecordDate { get; set; }
    }
}
