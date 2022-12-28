using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cobrador2
    {
        public Cobrador2()
        {
            Cliente2s = new HashSet<Cliente2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            Factura2s = new HashSet<Factura2>();
            Pedido2s = new HashSet<Pedido2>();
        }

        public string Cobrador { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Empleado { get; set; }
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
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
    }
}
