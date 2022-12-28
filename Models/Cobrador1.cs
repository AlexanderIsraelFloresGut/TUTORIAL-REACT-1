using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Cobrador1
    {
        public Cobrador1()
        {
            Cliente1s = new HashSet<Cliente1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            Factura1s = new HashSet<Factura1>();
            Pedido1s = new HashSet<Pedido1>();
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

        public virtual CentroCuentum1? Ct { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
    }
}
