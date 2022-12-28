using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwDashBoardSolped1
    {
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public string? Periodo { get; set; }
        public string? Mes { get; set; }
        public int? Anio { get; set; }
        public int? NumeroMes { get; set; }
    }
}
