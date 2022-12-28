using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CabeceraPedidoWeb1
    {
        public int Id { get; set; }
        public string? Consecutivo { get; set; }
        public string? Bodega { get; set; }
        public string? Cliente { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string? Estado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
