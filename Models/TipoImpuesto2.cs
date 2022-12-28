using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoImpuesto2
    {
        public TipoImpuesto2()
        {
            Cliente2s = new HashSet<Cliente2>();
            DiferidosImpuesto2s = new HashSet<DiferidosImpuesto2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            Impuesto2TipoImpuesto1Navigations = new HashSet<Impuesto2>();
            Impuesto2TipoImpuesto2Navigations = new HashSet<Impuesto2>();
            ImpuestoActivo2s = new HashSet<ImpuestoActivo2>();
            Proveedor2s = new HashSet<Proveedor2>();
            Retencione2s = new HashSet<Retencione2>();
            TipoTarifaIva2s = new HashSet<TipoTarifaIva2>();
            ValorAdicionalMe2s = new HashSet<ValorAdicionalMe2>();
        }

        public string TipoImpuesto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? CodigoTributo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DiferidosImpuesto2> DiferidosImpuesto2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<Impuesto2> Impuesto2TipoImpuesto1Navigations { get; set; }
        public virtual ICollection<Impuesto2> Impuesto2TipoImpuesto2Navigations { get; set; }
        public virtual ICollection<ImpuestoActivo2> ImpuestoActivo2s { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
        public virtual ICollection<Retencione2> Retencione2s { get; set; }
        public virtual ICollection<TipoTarifaIva2> TipoTarifaIva2s { get; set; }
        public virtual ICollection<ValorAdicionalMe2> ValorAdicionalMe2s { get; set; }
    }
}
