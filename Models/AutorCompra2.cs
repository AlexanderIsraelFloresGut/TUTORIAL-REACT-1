using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AutorCompra2
    {
        public AutorCompra2()
        {
            ClasificacionCompra2s = new HashSet<ClasificacionCompra2>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short Clasificacion { get; set; }
        public string NumAutor { get; set; } = null!;
        public DateTime FechaRige { get; set; }
        public DateTime FechaVence { get; set; }
        public decimal Porcentaje { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ClasificacionCompra2> ClasificacionCompra2s { get; set; }
    }
}
