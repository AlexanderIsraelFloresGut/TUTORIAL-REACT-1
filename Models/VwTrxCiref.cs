using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwTrxCiref
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime? FechaHoraTransac { get; set; }
        public DateTime Fecha { get; set; }
        public int AuditTransInv { get; set; }
        public string DocumentoCi { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Bodega { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoTotFiscLoc { get; set; }
        public decimal CostoTotFiscDol { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
