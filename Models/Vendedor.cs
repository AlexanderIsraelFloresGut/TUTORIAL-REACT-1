using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            ClienteVendedors = new HashSet<ClienteVendedor>();
            Clientes = new HashSet<Cliente>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            Facturas = new HashSet<Factura>();
            Pedidos = new HashSet<Pedido>();
        }

        public string Vendedor1 { get; set; } = null!;
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

        public virtual CentroCuentum? Ct { get; set; }
        public virtual ICollection<ClienteVendedor> ClienteVendedors { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
