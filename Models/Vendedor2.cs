using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Vendedor2
    {
        public Vendedor2()
        {
            Cliente2s = new HashSet<Cliente2>();
            ClienteVendedor2s = new HashSet<ClienteVendedor2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            Factura2s = new HashSet<Factura2>();
            Pedido2s = new HashSet<Pedido2>();
        }

        public string Vendedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public decimal Comision { get; set; }
        public string? CtrComision { get; set; }
        public string? CtaComision { get; set; }
        public string? EMail { get; set; }
        public string Activo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum2? Ct { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<ClienteVendedor2> ClienteVendedor2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
    }
}
