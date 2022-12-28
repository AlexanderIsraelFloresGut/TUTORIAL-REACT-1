using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmbarqueDocCp1
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

        public virtual DocumentosCp1 DocumentosCp1 { get; set; } = null!;
        public virtual Embarque1 EmbarqueNavigation { get; set; } = null!;
        public virtual LiquidacCompra1? LiquidacCompraNavigation { get; set; }
    }
}
