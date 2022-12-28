using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MrpAjusteCostoEstandar
    {
        public string AjusteConfig { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public int AuditTransInv { get; set; }
        public string Tipo { get; set; } = null!;
        public string Subtipo { get; set; } = null!;
        public string Subsubtipo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal CostoTotFiscLoc { get; set; }
        public decimal CostoTotFiscDol { get; set; }
        public DateTime Fecha { get; set; }
    }
}
