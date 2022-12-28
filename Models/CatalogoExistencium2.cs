using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CatalogoExistencium2
    {
        public CatalogoExistencium2()
        {
            Articulo2s = new HashSet<Articulo2>();
        }

        public string CatalogoExistencia { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo2> Articulo2s { get; set; }
    }
}
