using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TiposDetraccione2
    {
        public TiposDetraccione2()
        {
            Articulo2TiposDetraccione2Navigations = new HashSet<Articulo2>();
            Articulo2TiposDetraccione2s = new HashSet<Articulo2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Factura2s = new HashSet<Factura2>();
            RecepcionDetrac2s = new HashSet<RecepcionDetrac2>();
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

        public virtual ICollection<Articulo2> Articulo2TiposDetraccione2Navigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2TiposDetraccione2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Factura2> Factura2s { get; set; }
        public virtual ICollection<RecepcionDetrac2> RecepcionDetrac2s { get; set; }
    }
}
