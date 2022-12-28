using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SeriePlantilla2
    {
        public SeriePlantilla2()
        {
            Articulo2s = new HashSet<Articulo2>();
            Clasificacion2s = new HashSet<Clasificacion2>();
        }

        public string SeriePlantilla { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoSerie { get; set; } = null!;
        public string Mascara { get; set; } = null!;
        public string? SerieMinima { get; set; }
        public string? SerieMaxima { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<Clasificacion2> Clasificacion2s { get; set; }
    }
}
