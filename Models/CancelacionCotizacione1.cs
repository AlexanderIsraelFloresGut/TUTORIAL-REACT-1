using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CancelacionCotizacione1
    {
        public CancelacionCotizacione1()
        {
            Pedido1s = new HashSet<Pedido1>();
        }

        public string Razon { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Pedido1> Pedido1s { get; set; }
    }
}
