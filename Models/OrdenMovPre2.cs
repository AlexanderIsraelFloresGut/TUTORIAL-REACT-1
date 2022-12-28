using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenMovPre2
    {
        public OrdenMovPre2()
        {
            OrdenMovPresLinea2s = new HashSet<OrdenMovPresLinea2>();
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

        public virtual OrdenCompra2 OrdenCompraNavigation { get; set; } = null!;
        public virtual ICollection<OrdenMovPresLinea2> OrdenMovPresLinea2s { get; set; }
    }
}
