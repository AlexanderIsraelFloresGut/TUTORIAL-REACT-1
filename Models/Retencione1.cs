using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Retencione1
    {
        public Retencione1()
        {
            Articulo1CodigoRetencionNavigations = new HashSet<Articulo1>();
            Articulo1RetencionCompraNavigations = new HashSet<Articulo1>();
            AuxiliarCp1s = new HashSet<AuxiliarCp1>();
            ClienteRetencion1s = new HashSet<ClienteRetencion1>();
            DetRetencionCh1s = new HashSet<DetRetencionCh1>();
            DetalleRetencion1s = new HashSet<DetalleRetencion1>();
            DetalleRetencionCo1s = new HashSet<DetalleRetencionCo1>();
            ExcepCiudad1s = new HashSet<ExcepCiudad1>();
            FacturaRetencion1s = new HashSet<FacturaRetencion1>();
            InverseRetencionBaseNavigation = new HashSet<Retencione1>();
            ProvRetencion1s = new HashSet<ProvRetencion1>();
            RetencionesDocCc1s = new HashSet<RetencionesDocCc1>();
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
        public string? CodigoRegimen { get; set; }
        public string NocalculaRetsinIgv { get; set; } = null!;

        public virtual Clasificacion1? ClasificacionArtNavigation { get; set; }
        public virtual CodIngreso1? CodigoIngresoNavigation { get; set; }
        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual Retencione1? RetencionBaseNavigation { get; set; }
        public virtual TipoImpuesto1? TipoImpuestoNavigation { get; set; }
        public virtual ICollection<Articulo1> Articulo1CodigoRetencionNavigations { get; set; }
        public virtual ICollection<Articulo1> Articulo1RetencionCompraNavigations { get; set; }
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1s { get; set; }
        public virtual ICollection<ClienteRetencion1> ClienteRetencion1s { get; set; }
        public virtual ICollection<DetRetencionCh1> DetRetencionCh1s { get; set; }
        public virtual ICollection<DetalleRetencion1> DetalleRetencion1s { get; set; }
        public virtual ICollection<DetalleRetencionCo1> DetalleRetencionCo1s { get; set; }
        public virtual ICollection<ExcepCiudad1> ExcepCiudad1s { get; set; }
        public virtual ICollection<FacturaRetencion1> FacturaRetencion1s { get; set; }
        public virtual ICollection<Retencione1> InverseRetencionBaseNavigation { get; set; }
        public virtual ICollection<ProvRetencion1> ProvRetencion1s { get; set; }
        public virtual ICollection<RetencionesDocCc1> RetencionesDocCc1s { get; set; }
    }
}
