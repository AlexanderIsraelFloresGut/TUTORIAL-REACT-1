using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SeriePlantilla1
    {
        public SeriePlantilla1()
        {
            Articulo1s = new HashSet<Articulo1>();
            Clasificacion1s = new HashSet<Clasificacion1>();
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
        public string? UValor { get; set; }

        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<Clasificacion1> Clasificacion1s { get; set; }
    }
}
