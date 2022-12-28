using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuditoriaUsuario
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; } = null!;
        public string Accion { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string? Estado { get; set; }
        public string? NombreTabla { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
