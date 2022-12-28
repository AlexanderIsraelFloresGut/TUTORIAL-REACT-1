using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ItemsHaciendum1
    {
        public ItemsHaciendum1()
        {
            Articulo1s = new HashSet<Articulo1>();
            Cliente1s = new HashSet<Cliente1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            ExcepcionD1041s = new HashSet<ExcepcionD1041>();
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

        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<ExcepcionD1041> ExcepcionD1041s { get; set; }
    }
}
