using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EliminacionSincroPo1
    {
        public int IdSentencia { get; set; }
        public string TipoTienda { get; set; } = null!;
        public DateTime FechaEliminacion { get; set; }
        public string Sentencia { get; set; } = null!;
        public string NombreTabla { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaAplicacion { get; set; }
        public string? DetalleError { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
