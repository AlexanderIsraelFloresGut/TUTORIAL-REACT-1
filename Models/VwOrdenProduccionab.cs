using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwOrdenProduccionab
    {
        public long Op { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string NombreARticulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Lote { get; set; } = null!;
        public DateTime FechaVencimiento { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
