using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ItemsHaciendum2
    {
        public ItemsHaciendum2()
        {
            Articulo2s = new HashSet<Articulo2>();
            Cliente2s = new HashSet<Cliente2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            ExcepcionD1042s = new HashSet<ExcepcionD1042>();
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

        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<ExcepcionD1042> ExcepcionD1042s { get; set; }
    }
}
