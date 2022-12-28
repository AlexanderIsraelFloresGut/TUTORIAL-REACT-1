using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UsuariosAprobOc1
    {
        public string OrdenCompra { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaAprob { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenCompra1 OrdenCompraNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
