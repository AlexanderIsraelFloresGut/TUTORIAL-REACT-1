using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoImpuesto
    {
        public TipoImpuesto()
        {
            Clientes = new HashSet<Cliente>();
            DiferidosImpuestos = new HashSet<DiferidosImpuesto>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            ImpuestoActivos = new HashSet<ImpuestoActivo>();
            ImpuestoTipoImpuesto1Navigations = new HashSet<Impuesto>();
            ImpuestoTipoImpuesto2Navigations = new HashSet<Impuesto>();
            Proveedors = new HashSet<Proveedor>();
            Retenciones = new HashSet<Retencione>();
            TipoTarifaIvas = new HashSet<TipoTarifaIva>();
            ValorAdicionalMes = new HashSet<ValorAdicionalMe>();
        }

        public string TipoImpuesto1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? CodigoTributo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DiferidosImpuesto> DiferidosImpuestos { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<ImpuestoActivo> ImpuestoActivos { get; set; }
        public virtual ICollection<Impuesto> ImpuestoTipoImpuesto1Navigations { get; set; }
        public virtual ICollection<Impuesto> ImpuestoTipoImpuesto2Navigations { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<Retencione> Retenciones { get; set; }
        public virtual ICollection<TipoTarifaIva> TipoTarifaIvas { get; set; }
        public virtual ICollection<ValorAdicionalMe> ValorAdicionalMes { get; set; }
    }
}
