using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TiposDetraccione1
    {
        public TiposDetraccione1()
        {
            Articulo1TiposDetraccione1Navigations = new HashSet<Articulo1>();
            Articulo1TiposDetraccione1s = new HashSet<Articulo1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Factura1s = new HashSet<Factura1>();
            RecepcionDetrac1s = new HashSet<RecepcionDetrac1>();
        }

        public string TipoDetraccion { get; set; } = null!;
        public string DescTipoDetraccion { get; set; } = null!;
        public string CodDetraccion { get; set; } = null!;
        public string DescActividad { get; set; } = null!;
        public decimal PorcDetraccion { get; set; }
        public decimal MinDetraccion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Articulo1> Articulo1TiposDetraccione1Navigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1TiposDetraccione1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<RecepcionDetrac1> RecepcionDetrac1s { get; set; }
    }
}
