using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ItemsHaciendum
    {
        public ItemsHaciendum()
        {
            Articulos = new HashSet<Articulo>();
            Clientes = new HashSet<Cliente>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            ExcepcionD104s = new HashSet<ExcepcionD104>();
        }

        public string ItemHacienda { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? TipoTarifa { get; set; }
        public string Reporte { get; set; } = null!;
        public string FenomenoEconomico { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<ExcepcionD104> ExcepcionD104s { get; set; }
    }
}
