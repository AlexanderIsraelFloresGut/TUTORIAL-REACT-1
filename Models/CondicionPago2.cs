using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CondicionPago2
    {
        public CondicionPago2()
        {
            Cliente2s = new HashSet<Cliente2>();
            Contrarecibo2s = new HashSet<Contrarecibo2>();
            ContrarecibosCc2s = new HashSet<ContrarecibosCc2>();
            DescProntoPago2s = new HashSet<DescProntoPago2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Factura2s = new HashSet<Factura2>();
            NivelPrecio2s = new HashSet<NivelPrecio2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            PagosParciale2s = new HashSet<PagosParciale2>();
            Pedido2s = new HashSet<Pedido2>();
            Proveedor2s = new HashSet<Proveedor2>();
        }

        public string CondicionPago { get; set; } = null!;
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

        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<Contrarecibo2> Contrarecibo2s { get; set; }
        public virtual ICollection<ContrarecibosCc2> ContrarecibosCc2s { get; set; }
        public virtual ICollection<DescProntoPago2> DescProntoPago2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<NivelPrecio2> NivelPrecio2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<PagosParciale2> PagosParciale2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
    }
}
