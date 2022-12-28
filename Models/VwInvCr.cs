using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwInvCr
    {
        public string Empresa { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? DescripcionArticulo { get; set; }
        public string? CodigoFrigorifico { get; set; }
        public decimal Libras { get; set; }
        public decimal? Paquetes { get; set; }
        public decimal? CjMaster { get; set; }
        public short Bultos { get; set; }
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
    }
}
