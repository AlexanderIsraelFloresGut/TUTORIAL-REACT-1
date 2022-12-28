using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Retencione2
    {
        public Retencione2()
        {
            Articulo2CodigoRetencionNavigations = new HashSet<Articulo2>();
            Articulo2RetencionCompraNavigations = new HashSet<Articulo2>();
            AuxiliarCp2s = new HashSet<AuxiliarCp2>();
            ClienteRetencion2s = new HashSet<ClienteRetencion2>();
            DetRetencionCh2s = new HashSet<DetRetencionCh2>();
            DetalleRetencion2s = new HashSet<DetalleRetencion2>();
            DetalleRetencionCo2s = new HashSet<DetalleRetencionCo2>();
            ExcepCiudad2s = new HashSet<ExcepCiudad2>();
            FacturaRetencion2s = new HashSet<FacturaRetencion2>();
            InverseRetencionBaseNavigation = new HashSet<Retencione2>();
            ProvRetencion2s = new HashSet<ProvRetencion2>();
            RetencionesDocCc2s = new HashSet<RetencionesDocCc2>();
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

        public virtual Clasificacion2? ClasificacionArtNavigation { get; set; }
        public virtual CodIngreso2? CodigoIngresoNavigation { get; set; }
        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual Retencione2? RetencionBaseNavigation { get; set; }
        public virtual TipoImpuesto2? TipoImpuestoNavigation { get; set; }
        public virtual ICollection<Articulo2> Articulo2CodigoRetencionNavigations { get; set; }
        public virtual ICollection<Articulo2> Articulo2RetencionCompraNavigations { get; set; }
        public virtual ICollection<AuxiliarCp2> AuxiliarCp2s { get; set; }
        public virtual ICollection<ClienteRetencion2> ClienteRetencion2s { get; set; }
        public virtual ICollection<DetRetencionCh2> DetRetencionCh2s { get; set; }
        public virtual ICollection<DetalleRetencion2> DetalleRetencion2s { get; set; }
        public virtual ICollection<DetalleRetencionCo2> DetalleRetencionCo2s { get; set; }
        public virtual ICollection<ExcepCiudad2> ExcepCiudad2s { get; set; }
        public virtual ICollection<FacturaRetencion2> FacturaRetencion2s { get; set; }
        public virtual ICollection<Retencione2> InverseRetencionBaseNavigation { get; set; }
        public virtual ICollection<ProvRetencion2> ProvRetencion2s { get; set; }
        public virtual ICollection<RetencionesDocCc2> RetencionesDocCc2s { get; set; }
    }
}
