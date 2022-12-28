using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PrecioArtProv2
    {
        public string Articulo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public short Linea { get; set; }
        public decimal CantidadHasta { get; set; }
        public decimal Precio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Proveedor2 ProveedorNavigation { get; set; } = null!;
    }
}
