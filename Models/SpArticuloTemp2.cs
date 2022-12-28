using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpArticuloTemp2
    {
        public int PkspArticuloTemp { get; set; }
        public string Planificador { get; set; } = null!;
        public int Fkversion { get; set; }
        public int FkspHistorial { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Sugerido { get; set; }
        public string? ClaseTotal { get; set; }
        public decimal ConsumoPromedio { get; set; }
        public decimal InvMaximo { get; set; }
        public decimal InvTransito { get; set; }
        public decimal InvActual { get; set; }
        public decimal ReferenciaPedido { get; set; }
        public decimal SugerenciaPedido { get; set; }
        public string? Proveedor { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
