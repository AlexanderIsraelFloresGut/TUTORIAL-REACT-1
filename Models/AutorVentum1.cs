using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AutorVentum1
    {
        public AutorVentum1()
        {
            ClasificacionVentum1s = new HashSet<ClasificacionVentum1>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Cliente { get; set; } = null!;
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
        public string? TipoDoc { get; set; }
        public string? NombreInstitucion { get; set; }

        public virtual Cliente1 ClienteNavigation { get; set; } = null!;
        public virtual ICollection<ClasificacionVentum1> ClasificacionVentum1s { get; set; }
    }
}
