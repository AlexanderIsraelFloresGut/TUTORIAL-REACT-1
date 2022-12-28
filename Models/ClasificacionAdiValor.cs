using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionAdiValor
    {
        public ClasificacionAdiValor()
        {
            ClasificAdiArticulos = new HashSet<ClasificAdiArticulo>();
        }

        public string Clasificacion { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ClasificacionAdi ClasificacionNavigation { get; set; } = null!;
        public virtual ICollection<ClasificAdiArticulo> ClasificAdiArticulos { get; set; }
    }
}
