using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoExistencium
    {
        public TipoExistencium()
        {
            Articulos = new HashSet<Articulo>();
        }

        public string TipoExistencia { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
