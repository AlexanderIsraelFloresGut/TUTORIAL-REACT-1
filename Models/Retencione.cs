using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Retencione
    {
        public Retencione()
        {
            ArticuloCodigoRetencionNavigations = new HashSet<Articulo>();
            ArticuloRetencionCompraNavigations = new HashSet<Articulo>();
            AuxiliarCps = new HashSet<AuxiliarCp>();
            ClienteRetencions = new HashSet<ClienteRetencion>();
            DetRetencionChes = new HashSet<DetRetencionCh>();
            DetalleRetencionCos = new HashSet<DetalleRetencionCo>();
            DetalleRetencions = new HashSet<DetalleRetencion>();
            ExcepCiudads = new HashSet<ExcepCiudad>();
            FacturaRetencions = new HashSet<FacturaRetencion>();
            InverseRetencionBaseNavigation = new HashSet<Retencione>();
            ProvRetencions = new HashSet<ProvRetencion>();
            RetencionesDocCcs = new HashSet<RetencionesDocCc>();
        }

        public string CodigoRetencion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string Tipo { get; set; } = null!;
        public string AplicaMonto { get; set; } = null!;
        public string AplicaSubtotal { get; set; } = null!;
        public string AplicaSubDesc { get; set; } = null!;
        public string AplicaImpuesto1 { get; set; } = null!;
        public string AplicaImpuesto2 { get; set; } = null!;
        public string AplicaRubro1 { get; set; } = null!;
        public string AplicaRubro2 { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public decimal MontoMinimo { get; set; }
        public string? CtrRetencion { get; set; }
        public string? CtaRetencion { get; set; }
        public string? RetPorArticulo { get; set; }
        public string? EsAutoretenedor { get; set; }
        public string? ClasificacionArt { get; set; }
        public string? CtrAutoretencion { get; set; }
        public string? CtaAutoretencion { get; set; }
        public string TipoExcepcion { get; set; } = null!;
        public string NoaplicaProvAuto { get; set; } = null!;
        public string AplicaRetencion { get; set; } = null!;
        public string? RetencionBase { get; set; }
        public string AplicaImp1Desc { get; set; } = null!;
        public string AplicaImp1Nodesc { get; set; } = null!;
        public string? TipoDocCcCredito { get; set; }
        public string? TipoDocCcDebito { get; set; }
        public string? TipoDocCpCredito { get; set; }
        public string? TipoDocCpDebito { get; set; }
        public string UtilizaTarifaUvt { get; set; } = null!;
        public string? ConsecRetVenta { get; set; }
        public string? ConsecRetCompra { get; set; }
        public string PerGenerarRetCero { get; set; } = null!;
        public string TipoApliCancelar { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CodigoIngreso { get; set; }
        public string? UImpuestoSat { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? UClaveRet { get; set; }
        public string? UCodRet { get; set; }
        public string? UImpuesto { get; set; }
        public string AplicaSubBienes { get; set; } = null!;
        public string AplicaSubServicios { get; set; } = null!;

        public virtual Clasificacion? ClasificacionArtNavigation { get; set; }
        public virtual CodIngreso? CodigoIngresoNavigation { get; set; }
        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual Retencione? RetencionBaseNavigation { get; set; }
        public virtual TipoImpuesto? TipoImpuestoNavigation { get; set; }
        public virtual ICollection<Articulo> ArticuloCodigoRetencionNavigations { get; set; }
        public virtual ICollection<Articulo> ArticuloRetencionCompraNavigations { get; set; }
        public virtual ICollection<AuxiliarCp> AuxiliarCps { get; set; }
        public virtual ICollection<ClienteRetencion> ClienteRetencions { get; set; }
        public virtual ICollection<DetRetencionCh> DetRetencionChes { get; set; }
        public virtual ICollection<DetalleRetencionCo> DetalleRetencionCos { get; set; }
        public virtual ICollection<DetalleRetencion> DetalleRetencions { get; set; }
        public virtual ICollection<ExcepCiudad> ExcepCiudads { get; set; }
        public virtual ICollection<FacturaRetencion> FacturaRetencions { get; set; }
        public virtual ICollection<Retencione> InverseRetencionBaseNavigation { get; set; }
        public virtual ICollection<ProvRetencion> ProvRetencions { get; set; }
        public virtual ICollection<RetencionesDocCc> RetencionesDocCcs { get; set; }
    }
}
