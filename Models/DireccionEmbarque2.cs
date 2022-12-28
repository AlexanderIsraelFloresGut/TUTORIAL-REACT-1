using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DireccionEmbarque2
    {
        public DireccionEmbarque2()
        {
            OrdenCompra2s = new HashSet<OrdenCompra2>();
        }

        public string CodigoDireccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
    }
}
