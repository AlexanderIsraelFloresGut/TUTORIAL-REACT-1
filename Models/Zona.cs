using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Zona
    {
        public Zona()
        {
            Clientes = new HashSet<Cliente>();
            Facturas = new HashSet<Factura>();
            Pedidos = new HashSet<Pedido>();
        }

        public string Zona1 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
