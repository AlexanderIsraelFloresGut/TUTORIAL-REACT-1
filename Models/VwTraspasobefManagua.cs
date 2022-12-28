using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwTraspasobefManagua
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public string Articulo { get; set; } = null!;
        public string TipoTransacion { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string? Especie { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? Naturaleza { get; set; }
        public decimal? Libras { get; set; }
        public decimal? LibrasAbs { get; set; }
        public decimal? MontoNio { get; set; }
        public decimal? MontoUsd { get; set; }
    }
}
