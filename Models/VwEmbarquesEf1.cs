using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmbarquesEf1
    {
        public DateTime? Fecha { get; set; }
        public string? Proveedor { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal? Libras { get; set; }
        public decimal? Monto { get; set; }
    }
}
