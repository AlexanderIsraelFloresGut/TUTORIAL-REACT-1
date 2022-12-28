using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DespachoBcfood1
    {
        public string? Pedido { get; set; }
        public string? Articulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Precio { get; set; }
        public decimal? CantidadFacturar { get; set; }
        public decimal? Escaneada { get; set; }
        public string? Lote { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
