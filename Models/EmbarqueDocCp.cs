using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmbarqueDocCp
    {
        public string Proveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public string? Notas { get; set; }
        public decimal? MontoAplicar { get; set; }
        public string? LiquidacCompra { get; set; }
        public string? Etiqueta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DocumentosCp DocumentosCp { get; set; } = null!;
        public virtual Embarque EmbarqueNavigation { get; set; } = null!;
        public virtual LiquidacCompra? LiquidacCompraNavigation { get; set; }
    }
}
