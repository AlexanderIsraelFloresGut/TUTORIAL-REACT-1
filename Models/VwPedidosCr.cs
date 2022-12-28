using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwPedidosCr
    {
        public string Pedido { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public short LineaUsuario { get; set; }
        public string Bodega { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? CodFirogrifico { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal CantidadPedida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? Total { get; set; }
        public decimal Volumen { get; set; }
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
        public short Bultos { get; set; }
        public decimal? CajasP { get; set; }
    }
}
