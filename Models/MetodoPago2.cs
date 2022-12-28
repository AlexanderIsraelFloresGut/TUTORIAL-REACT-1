using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MetodoPago2
    {
        public MetodoPago2()
        {
            Cheque2s = new HashSet<Cheque2>();
            Cliente2s = new HashSet<Cliente2>();
            DetTransCb2s = new HashSet<DetTransCb2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            MovBanco2s = new HashSet<MovBanco2>();
            TransferenciaCb2s = new HashSet<TransferenciaCb2>();
        }

        public string MetodoPago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cheque2> Cheque2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DetTransCb2> DetTransCb2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<TransferenciaCb2> TransferenciaCb2s { get; set; }
    }
}
