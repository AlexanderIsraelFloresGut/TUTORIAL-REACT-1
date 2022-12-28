using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesgloseArtTmp2
    {
        public string Orden { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string FuenteConsumo { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public string? Modo { get; set; }
        public int? SerieCadena { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SerieCadena2? SerieCadenaNavigation { get; set; }
    }
}
