using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Monedum1
    {
        public Monedum1()
        {
            ArticuloCompra1s = new HashSet<ArticuloCompra1>();
            AuxiliarCc1MonedaCreditoNavigations = new HashSet<AuxiliarCc1>();
            AuxiliarCc1MonedaDebitoNavigations = new HashSet<AuxiliarCc1>();
            AuxiliarCp1MonedaCreditoNavigations = new HashSet<AuxiliarCp1>();
            AuxiliarCp1MonedaDebitoNavigations = new HashSet<AuxiliarCp1>();
            CajaChica1s = new HashSet<CajaChica1>();
            CartaPorteMercancia = new HashSet<CartaPorteMercancium>();
            Cliente1s = new HashSet<Cliente1>();
            ConceptoLiquidac1s = new HashSet<ConceptoLiquidac1>();
            CuentaBancarium1s = new HashSet<CuentaBancarium1>();
            DetTransCb1s = new HashSet<DetTransCb1>();
            Devolucion1s = new HashSet<Devolucion1>();
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
            Liquidacion1s = new HashSet<Liquidacion1>();
            LiquidacionPago1s = new HashSet<LiquidacionPago1>();
            MonedaHist1s = new HashSet<MonedaHist1>();
            Nomina1s = new HashSet<Nomina1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            Proveedor1s = new HashSet<Proveedor1>();
            ProveedorEntidad1s = new HashSet<ProveedorEntidad1>();
            SaldoCliente1s = new HashSet<SaldoCliente1>();
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

        public virtual ICollection<ArticuloCompra1> ArticuloCompra1s { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1MonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc1> AuxiliarCc1MonedaDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1MonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1MonedaDebitoNavigations { get; set; }
        public virtual ICollection<CajaChica1> CajaChica1s { get; set; }
        public virtual ICollection<CartaPorteMercancium> CartaPorteMercancia { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<ConceptoLiquidac1> ConceptoLiquidac1s { get; set; }
        public virtual ICollection<CuentaBancarium1> CuentaBancarium1s { get; set; }
        public virtual ICollection<DetTransCb1> DetTransCb1s { get; set; }
        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
        public virtual ICollection<Liquidacion1> Liquidacion1s { get; set; }
        public virtual ICollection<LiquidacionPago1> LiquidacionPago1s { get; set; }
        public virtual ICollection<MonedaHist1> MonedaHist1s { get; set; }
        public virtual ICollection<Nomina1> Nomina1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
        public virtual ICollection<ProveedorEntidad1> ProveedorEntidad1s { get; set; }
        public virtual ICollection<SaldoCliente1> SaldoCliente1s { get; set; }
    }
}
