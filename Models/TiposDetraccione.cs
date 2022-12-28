using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TiposDetraccione
    {
        public TiposDetraccione()
        {
            ArticuloTiposDetraccioneNavigations = new HashSet<Articulo>();
            ArticuloTiposDetracciones = new HashSet<Articulo>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            Facturas = new HashSet<Factura>();
            RecepcionDetracs = new HashSet<RecepcionDetrac>();
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

        public virtual ICollection<Articulo> ArticuloTiposDetraccioneNavigations { get; set; }
        public virtual ICollection<Articulo> ArticuloTiposDetracciones { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<RecepcionDetrac> RecepcionDetracs { get; set; }
    }
}
