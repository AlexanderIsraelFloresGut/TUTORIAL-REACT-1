using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClasificAdiArticulo
    {
        public string Articulo { get; set; } = null!;
        public string Clasificacion { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual ClasificacionAdiValor ClasificacionAdiValor { get; set; } = null!;
    }
}
