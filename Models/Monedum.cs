using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Monedum
    {
        public Monedum()
        {
            ArticuloCompras = new HashSet<ArticuloCompra>();
            AuxiliarCcMonedaCreditoNavigations = new HashSet<AuxiliarCc>();
            AuxiliarCcMonedaDebitoNavigations = new HashSet<AuxiliarCc>();
            AuxiliarCpMonedaCreditoNavigations = new HashSet<AuxiliarCp>();
            AuxiliarCpMonedaDebitoNavigations = new HashSet<AuxiliarCp>();
            CajaChicas = new HashSet<CajaChica>();
            Clientes = new HashSet<Cliente>();
            ConceptoLiquidacs = new HashSet<ConceptoLiquidac>();
            CuentaBancaria = new HashSet<CuentaBancarium>();
            DetTransCbs = new HashSet<DetTransCb>();
            Devolucions = new HashSet<Devolucion>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            LiquidacGastos = new HashSet<LiquidacGasto>();
            LiquidacionPagos = new HashSet<LiquidacionPago>();
            Liquidacions = new HashSet<Liquidacion>();
            MonedaHists = new HashSet<MonedaHist>();
            Nominas = new HashSet<Nomina>();
            OrdenCompras = new HashSet<OrdenCompra>();
            ProveedorEntidads = new HashSet<ProveedorEntidad>();
            Proveedors = new HashSet<Proveedor>();
            SaldoClientes = new HashSet<SaldoCliente>();
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

        public virtual ICollection<ArticuloCompra> ArticuloCompras { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcMonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCc> AuxiliarCcMonedaDebitoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp> AuxiliarCpMonedaCreditoNavigations { get; set; }
        public virtual ICollection<AuxiliarCp> AuxiliarCpMonedaDebitoNavigations { get; set; }
        public virtual ICollection<CajaChica> CajaChicas { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ConceptoLiquidac> ConceptoLiquidacs { get; set; }
        public virtual ICollection<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual ICollection<DetTransCb> DetTransCbs { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<LiquidacGasto> LiquidacGastos { get; set; }
        public virtual ICollection<LiquidacionPago> LiquidacionPagos { get; set; }
        public virtual ICollection<Liquidacion> Liquidacions { get; set; }
        public virtual ICollection<MonedaHist> MonedaHists { get; set; }
        public virtual ICollection<Nomina> Nominas { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<ProveedorEntidad> ProveedorEntidads { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<SaldoCliente> SaldoClientes { get; set; }
    }
}
