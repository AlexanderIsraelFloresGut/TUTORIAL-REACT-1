using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TablePedidoExcel
    {
        public string? Consecutivo { get; set; }
        public string? Articulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Cantidad { get; set; }
        public string? Precio { get; set; }
        public string? Actividad { get; set; }
        public string? Escaneada { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
