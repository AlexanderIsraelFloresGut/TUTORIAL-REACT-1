using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificacionAdi2
    {
        public ClasificacionAdi2()
        {
            ClasificacionAdiValor2s = new HashSet<ClasificacionAdiValor2>();
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

        public virtual ICollection<ClasificacionAdiValor2> ClasificacionAdiValor2s { get; set; }
    }
}
