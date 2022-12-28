using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteContenedor
    {
        public string Contenedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? MatriculaContenedor { get; set; }
        public string? TipoContenedor { get; set; }
        public string? NumPrecinto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteContMaritimo? TipoContenedorNavigation { get; set; }
    }
}
