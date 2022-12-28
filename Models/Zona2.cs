using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Zona2
    {
        public Zona2()
        {
            Cliente2s = new HashSet<Cliente2>();
            Factura2s = new HashSet<Factura2>();
            Pedido2s = new HashSet<Pedido2>();
        }

        public string Zona { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
    }
}
