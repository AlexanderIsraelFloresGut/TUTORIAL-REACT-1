using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteInventarioPeru2
    {
        public string Formato { get; set; } = null!;
        public string GuidFormato { get; set; } = null!;
        public string? CodigoOperacion { get; set; }
        public string? NumeroCorrelativo { get; set; }
        public string CodigoEstablecimiento { get; set; } = null!;
        public string CodigoCatalogo { get; set; } = null!;
        public string TipoExistencia { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? CodigoExistenciaSunat { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; } = null!;
        public string NumeroSerieDoc { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public string UnidadMedida { get; set; } = null!;
        public string Naturaleza { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal CostoUnitarioTrans { get; set; }
        public decimal CostoTotalTrans { get; set; }
        public string EstadoOperacion { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal CostoUnitarioSaldo { get; set; }
        public decimal CostoTotalSaldo { get; set; }
        public string TipoTransac { get; set; } = null!;
    }
}
