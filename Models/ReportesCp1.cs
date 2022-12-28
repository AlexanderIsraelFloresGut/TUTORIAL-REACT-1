using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReportesCp1
    {
        public string? Reporte { get; set; }
        public string? Proveedor { get; set; }
        public string? Documento { get; set; }
        public string? Tipo { get; set; }
        public string? Moneda { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaVence { get; set; }
        public decimal? TipoCambActLoc { get; set; }
        public decimal? TipoCambActDol { get; set; }
        public decimal? TipoCambActProv { get; set; }
        public string? Contrarecibo { get; set; }
        public string? Asiento { get; set; }
        public string? CondicionPago { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? MontoRetencion { get; set; }
        public decimal? SaldoRetencion { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Rubro1 { get; set; }
        public decimal? Rubro2 { get; set; }
        public string? Aplicacion { get; set; }
        public string? DescSubtipo { get; set; }
        public int? DiasNeto { get; set; }
        public decimal? MontoDoc { get; set; }
        public decimal? MontoProv { get; set; }
        public decimal? MontoLocal { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? SaldoProv { get; set; }
        public decimal? SaldoLocal { get; set; }
        public decimal? SaldoDolar { get; set; }
        public decimal? SaldoRango0 { get; set; }
        public decimal? SaldoRango1 { get; set; }
        public decimal? SaldoRango2 { get; set; }
        public decimal? SaldoRango3 { get; set; }
        public decimal? SaldoRango4 { get; set; }
        public decimal? SaldoRango5 { get; set; }
        public string? TipoCondpago { get; set; }
        public int? NumParcialidades { get; set; }
        public int? Parcialidad { get; set; }
        public decimal? ParMontoPrincipal { get; set; }
        public decimal? ParMontoAmortiza { get; set; }
        public decimal? ParSaldoAmortiza { get; set; }
        public decimal? ParMontoInteres { get; set; }
        public decimal? ParSaldoInteres { get; set; }
        public decimal? ParMontoCuota { get; set; }
        public decimal? ParSaldoCuota { get; set; }
        public decimal? ParSaldoPrincipal { get; set; }
    }
}
