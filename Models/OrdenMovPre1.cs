using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenMovPre1
    {
        public OrdenMovPre1()
        {
            OrdenMovPresLinea1s = new HashSet<OrdenMovPresLinea1>();
        }

        public string OrdenCompra { get; set; } = null!;
        public string Presupuesto { get; set; } = null!;
        public string UnidadOperativa { get; set; } = null!;
        public int Numero { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenCompra1 OrdenCompraNavigation { get; set; } = null!;
        public virtual ICollection<OrdenMovPresLinea1> OrdenMovPresLinea1s { get; set; }
    }
}
