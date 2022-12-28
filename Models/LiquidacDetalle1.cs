using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacDetalle1
    {
        public string LiquidacCompra { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public short EmbarqueLinea { get; set; }
        public int Linea { get; set; }
        public string Rubro { get; set; } = null!;
        public string Etiqueta { get; set; } = null!;
        public decimal MontoLocal { get; set; }
        public decimal MontoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EmbarqueLinea1 EmbarqueNavigation { get; set; } = null!;
        public virtual LiquidacCompra1 LiquidacCompraNavigation { get; set; } = null!;
    }
}
