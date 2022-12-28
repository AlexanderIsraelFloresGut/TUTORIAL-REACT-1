using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DireccionEmbarque1
    {
        public DireccionEmbarque1()
        {
            OrdenCompra1s = new HashSet<OrdenCompra1>();
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

        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
    }
}
