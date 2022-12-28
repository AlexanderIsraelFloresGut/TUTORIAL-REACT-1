using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Cheques = new HashSet<Cheque>();
            Clientes = new HashSet<Cliente>();
            DetTransCbs = new HashSet<DetTransCb>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            MovBancos = new HashSet<MovBanco>();
            TransferenciaCbs = new HashSet<TransferenciaCb>();
        }

        public string MetodoPago1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DetTransCb> DetTransCbs { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<TransferenciaCb> TransferenciaCbs { get; set; }
    }
}
