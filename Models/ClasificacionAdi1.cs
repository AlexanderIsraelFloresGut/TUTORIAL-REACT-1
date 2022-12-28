using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionAdi1
    {
        public ClasificacionAdi1()
        {
            ClasificacionAdiValor1s = new HashSet<ClasificacionAdiValor1>();
        }

        public string Clasificacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short Posicion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ClasificacionAdiValor1> ClasificacionAdiValor1s { get; set; }
    }
}
