using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionAdiValor1
    {
        public ClasificacionAdiValor1()
        {
            ClasificAdiArticulo1s = new HashSet<ClasificAdiArticulo1>();
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

        public virtual ClasificacionAdi1 ClasificacionNavigation { get; set; } = null!;
        public virtual ICollection<ClasificAdiArticulo1> ClasificAdiArticulo1s { get; set; }
    }
}
