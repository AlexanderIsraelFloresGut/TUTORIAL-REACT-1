using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoImpuesto1
    {
        public TipoImpuesto1()
        {
            Cliente1s = new HashSet<Cliente1>();
            DiferidosImpuesto1s = new HashSet<DiferidosImpuesto1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            Impuesto1TipoImpuesto1Navigations = new HashSet<Impuesto1>();
            Impuesto1TipoImpuesto2Navigations = new HashSet<Impuesto1>();
            ImpuestoActivo1s = new HashSet<ImpuestoActivo1>();
            Proveedor1s = new HashSet<Proveedor1>();
            Retencione1s = new HashSet<Retencione1>();
            TipoTarifaIva1s = new HashSet<TipoTarifaIva1>();
            ValorAdicionalMe1s = new HashSet<ValorAdicionalMe1>();
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

        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DiferidosImpuesto1> DiferidosImpuesto1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<Impuesto1> Impuesto1TipoImpuesto1Navigations { get; set; }
        public virtual ICollection<Impuesto1> Impuesto1TipoImpuesto2Navigations { get; set; }
        public virtual ICollection<ImpuestoActivo1> ImpuestoActivo1s { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
        public virtual ICollection<Retencione1> Retencione1s { get; set; }
        public virtual ICollection<TipoTarifaIva1> TipoTarifaIva1s { get; set; }
        public virtual ICollection<ValorAdicionalMe1> ValorAdicionalMe1s { get; set; }
    }
}
