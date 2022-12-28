using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Monedum2
    {
        public Monedum2()
        {
            ArticuloCompra2s = new HashSet<ArticuloCompra2>();
            AuxiliarCc2MonedaCreditoNavigations = new HashSet<AuxiliarCc2>();
            AuxiliarCc2MonedaDebitoNavigations = new HashSet<AuxiliarCc2>();
            AuxiliarCp2MonedaCreditoNavigations = new HashSet<AuxiliarCp2>();
            AuxiliarCp2MonedaDebitoNavigations = new HashSet<AuxiliarCp2>();
            CajaChica2s = new HashSet<CajaChica2>();
            Cliente2s = new HashSet<Cliente2>();
            ConceptoLiquidac2s = new HashSet<ConceptoLiquidac2>();
            CuentaBancarium2s = new HashSet<CuentaBancarium2>();
            DetTransCb2s = new HashSet<DetTransCb2>();
            Devolucion2s = new HashSet<Devolucion2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
            Liquidacion2s = new HashSet<Liquidacion2>();
            LiquidacionPago2s = new HashSet<LiquidacionPago2>();
            MonedaHist2s = new HashSet<MonedaHist2>();
            Nomina2s = new HashSet<Nomina2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            Proveedor2s = new HashSet<Proveedor2>();
            ProveedorEntidad2s = new HashSet<ProveedorEntidad2>();
            SaldoCliente2s = new HashSet<SaldoCliente2>();
        }

        public string Moneda { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? CodigoIso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ArticuloCompra2> ArticuloCompra2s { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2MonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc2> AuxiliarCc2MonedaDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp2> AuxiliarCp2MonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp2> AuxiliarCp2MonedaDebitoNavigations { get; set; }
        public virtual ICollection<CajaChica2> CajaChica2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<ConceptoLiquidac2> ConceptoLiquidac2s { get; set; }
        public virtual ICollection<CuentaBancarium2> CuentaBancarium2s { get; set; }
        public virtual ICollection<DetTransCb2> DetTransCb2s { get; set; }
        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
        public virtual ICollection<Liquidacion2> Liquidacion2s { get; set; }
        public virtual ICollection<LiquidacionPago2> LiquidacionPago2s { get; set; }
        public virtual ICollection<MonedaHist2> MonedaHist2s { get; set; }
        public virtual ICollection<Nomina2> Nomina2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
        public virtual ICollection<ProveedorEntidad2> ProveedorEntidad2s { get; set; }
        public virtual ICollection<SaldoCliente2> SaldoCliente2s { get; set; }
    }
}
