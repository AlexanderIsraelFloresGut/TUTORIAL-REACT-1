using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExvArticulo1
    {
        public Guid RowPointer { get; set; }
        public string? Congelado { get; set; }
        public string? Fresco { get; set; }
        public string Presentacion { get; set; } = null!;
        public string Reintegro { get; set; } = null!;
        public string? Serie { get; set; }
        public string? VentaLocal { get; set; }
        public string? Walmart { get; set; }
    }
}
