using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Devolucion
    {
        public Devolucion()
        {
            DevolLinEmbarques = new HashSet<DevolLinEmbarque>();
        }

        public string Devolucion1 { get; set; } = null!;
        public string UsuarioCreado { get; set; } = null!;
        public string AjusteConfig { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int? AuditTransInv { get; set; }
        public string TipoDevolucion { get; set; } = null!;
        public DateTime FechaDevolucion { get; set; }
        public string AfectaOrden { get; set; } = null!;
        public string DocumentoDebito { get; set; } = null!;
        public string? Asiento { get; set; }
        public string? Notas { get; set; }
        public string? NumeroDebito { get; set; }
        public short? Subtipo { get; set; }
        public DateTime? FechaDocdebito { get; set; }
        public string? Aplicacion { get; set; }
        public DateTime FechaHoraCreado { get; set; }
        public DateTime? FechaHoraAplic { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public string? UsuarioAplicado { get; set; }
        public string? UsuarioCancela { get; set; }
        public string? MonedaDdeb { get; set; }
        public string? ProveedorDdeb { get; set; }
        public decimal? TcMonedaLocal { get; set; }
        public decimal? TcMonedaDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaCai { get; set; }
        public string? Cai { get; set; }
        public string? TipoAfectacionIva { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public decimal? PorcAfectacionIva { get; set; }
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }
        public string? NcfModificado { get; set; }
        public string? ActividadComercial { get; set; }
        public string? TipoPago { get; set; }
        public decimal? DeducCostoEnajena { get; set; }
        public decimal? RentaNeta { get; set; }
        public string? TipoRenta { get; set; }
        public string? ModalidadServicio { get; set; }
        public int? AnioDua { get; set; }
        public string? Clasificacion { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public DateTime? FechaRige { get; set; }
        public string? SerieNumero { get; set; }

        public virtual AjusteConfig AjusteConfigNavigation { get; set; } = null!;
        public virtual ClasifBienesServAdq? ClasificacionNavigation { get; set; }
        public virtual Embarque EmbarqueNavigation { get; set; } = null!;
        public virtual ModalidadServicio? ModalidadServicioNavigation { get; set; }
        public virtual Monedum? MonedaDdebNavigation { get; set; }
        public virtual Proveedor? ProveedorDdebNavigation { get; set; }
        public virtual TipoPago? TipoPagoNavigation { get; set; }
        public virtual TiposRentum? TipoRentaNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicadoNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2 UsuarioCreadoNavigation { get; set; } = null!;
        public virtual ICollection<DevolLinEmbarque> DevolLinEmbarques { get; set; }
    }
}
