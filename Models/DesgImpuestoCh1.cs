using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesgImpuestoCh1
    {
        public int Vale { get; set; }
        public int Linea { get; set; }
        public string CodigoImpuesto { get; set; } = null!;
        public decimal? Porcentaje { get; set; }
        public decimal Monto { get; set; }
        public decimal? Base { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Impuesto1 CodigoImpuestoNavigation { get; set; } = null!;
        public virtual DocsSoporte1 DocsSoporte1 { get; set; } = null!;
    }
}
