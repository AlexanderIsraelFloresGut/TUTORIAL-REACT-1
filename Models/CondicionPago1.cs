using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CondicionPago1
    {
        public CondicionPago1()
        {
            Cliente1s = new HashSet<Cliente1>();
            Contrarecibo1s = new HashSet<Contrarecibo1>();
            ContrarecibosCc1s = new HashSet<ContrarecibosCc1>();
            DescProntoPago1s = new HashSet<DescProntoPago1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Factura1s = new HashSet<Factura1>();
            NivelPrecio1s = new HashSet<NivelPrecio1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            PagosParciale1s = new HashSet<PagosParciale1>();
            Pedido1s = new HashSet<Pedido1>();
            Proveedor1s = new HashSet<Proveedor1>();
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

        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<Contrarecibo1> Contrarecibo1s { get; set; }
        public virtual ICollection<ContrarecibosCc1> ContrarecibosCc1s { get; set; }
        public virtual ICollection<DescProntoPago1> DescProntoPago1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<NivelPrecio1> NivelPrecio1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<PagosParciale1> PagosParciale1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
    }
}
