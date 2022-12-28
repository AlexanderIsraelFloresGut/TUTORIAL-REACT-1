using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoMenu
    {
        public int IdTipoMenu { get; set; }
        public int? MenuSuperior { get; set; }
        public string? Objeto { get; set; }
        public string? Ruta { get; set; }
        public int? IdCategoriaMenu { get; set; }
        public decimal? Orden { get; set; }
        public DateTime? FechaCreado { get; set; }
        public bool? Activo { get; set; }
        public int? Sistema { get; set; }
        public string? Class { get; set; }
    }
}
