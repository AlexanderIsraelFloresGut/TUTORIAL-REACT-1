using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoNc
    {
        public TipoNc()
        {
            DocumentosCcs = new HashSet<DocumentosCc>();
            Facturas = new HashSet<Factura>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
