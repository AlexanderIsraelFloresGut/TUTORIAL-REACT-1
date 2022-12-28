using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwDevXEmbarque
    {
        public string Embarque { get; set; } = null!;
        public string Devolucion { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public short EmbarqueLinea { get; set; }
        public short DevolucionLinea { get; set; }
        public string Bodega { get; set; } = null!;
        public decimal CantDevuelta { get; set; }
        public decimal CantDevueltaua { get; set; }
        public string Usuario { get; set; } = null!;
        public string Empresa { get; set; } = null!;
    }
}
