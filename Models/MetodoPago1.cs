using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MetodoPago1
    {
        public MetodoPago1()
        {
            Cheque1s = new HashSet<Cheque1>();
            Cliente1s = new HashSet<Cliente1>();
            DetTransCb1s = new HashSet<DetTransCb1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            MovBanco1s = new HashSet<MovBanco1>();
            TransferenciaCb1s = new HashSet<TransferenciaCb1>();
        }

        public string MetodoPago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cheque1> Cheque1s { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DetTransCb1> DetTransCb1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<TransferenciaCb1> TransferenciaCb1s { get; set; }
    }
}
