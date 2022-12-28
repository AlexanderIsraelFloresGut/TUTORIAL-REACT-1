using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CondicionPago
    {
        public CondicionPago()
        {
            Clientes = new HashSet<Cliente>();
            Contrarecibos = new HashSet<Contrarecibo>();
            ContrarecibosCcs = new HashSet<ContrarecibosCc>();
            DescProntoPagos = new HashSet<DescProntoPago>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            Facturas = new HashSet<Factura>();
            NivelPrecios = new HashSet<NivelPrecio>();
            OrdenCompras = new HashSet<OrdenCompra>();
            PagosParcialesNavigation = new HashSet<PagosParciale>();
            Pedidos = new HashSet<Pedido>();
            Proveedors = new HashSet<Proveedor>();
        }

        public string CondicionPago1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int DiasNeto { get; set; }
        public string PagosParciales { get; set; } = null!;
        public decimal DescuentoContado { get; set; }
        public string TipoCondpago { get; set; } = null!;
        public int? PlazoCondpago { get; set; }
        public string? TipoDiferido { get; set; }
        public string UsaDiferido { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UMetodoPago { get; set; }
        public string? UFormaPago { get; set; }
        public string? UPlazoPago { get; set; }
        public string? CondicionVenta { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Contrarecibo> Contrarecibos { get; set; }
        public virtual ICollection<ContrarecibosCc> ContrarecibosCcs { get; set; }
        public virtual ICollection<DescProntoPago> DescProntoPagos { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<NivelPrecio> NivelPrecios { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<PagosParciale> PagosParcialesNavigation { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
