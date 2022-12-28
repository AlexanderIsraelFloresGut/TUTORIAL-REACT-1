using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwSolicitudesAlinsa
    {
        public string Estado { get; set; } = null!;
        public string NoSolicitud { get; set; } = null!;
        public short Linea { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public string? Comentario { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DiaPedido { get; set; }
        public DateTime FechaRequerida { get; set; }
    }
}
