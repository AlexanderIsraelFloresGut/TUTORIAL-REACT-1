using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenCompra1
    {
        public OrdenCompra1()
        {
            DetDocumentoOrden1s = new HashSet<DetDocumentoOrden1>();
            OrdenCompraImp1s = new HashSet<OrdenCompraImp1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            OrdenMovPre1s = new HashSet<OrdenMovPre1>();
            UsuariosAprobOc1s = new HashSet<UsuariosAprobOc1>();
        }

        public string OrdenCompra { get; set; } = null!;
        public string? Usuario { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string? ResponSeguimiento { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime? FechaCotizacion { get; set; }
        public DateTime? FechaOfrecida { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaReqEmbarque { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string? DireccionEmbarque { get; set; }
        public string? DireccionCobro { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public decimal PorcDescuento { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal TotalMercaderia { get; set; }
        public decimal TotalImpuesto1 { get; set; }
        public decimal TotalImpuesto2 { get; set; }
        public decimal MontoFlete { get; set; }
        public decimal MontoSeguro { get; set; }
        public decimal MontoDocumentacio { get; set; }
        public decimal MontoAnticipo { get; set; }
        public decimal TotalAComprar { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string Prioridad { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Impresa { get; set; } = null!;
        public string? NumFormulario { get; set; }
        public string? Instrucciones { get; set; }
        public string? ComentarioCxp { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Observaciones { get; set; }
        public string RequiereConfirma { get; set; } = null!;
        public string Confirmada { get; set; } = null!;
        public string? UsuarioConfirma { get; set; }
        public DateTime? FechaHoraConfir { get; set; }
        public string? UsuarioCierre { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public string? AsientoCierre { get; set; }
        public string OrdenProgramada { get; set; } = null!;
        public string RecibidoDeMas { get; set; } = null!;
        public DateTime? FechaHoraCancela { get; set; }
        public string? UsuarioCancela { get; set; }
        public string? TipoProrrateoOc { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? CodDirecEmb { get; set; }
        public string? NotasNoaprobar { get; set; }
        public string? Departamento { get; set; }
        public DateTime? FechaUltNotif { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public decimal? TotImp1AsumDesc { get; set; }
        public decimal? TotImp1AsumNodesc { get; set; }
        public decimal? TotImp1ReteDesc { get; set; }
        public decimal? TotImp1ReteNodesc { get; set; }
        public DateTime? FechaNoAprueba { get; set; }
        public string? UsuarioNoAprueba { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string EstadoRecepcion { get; set; } = null!;
        public long? OrdenProduccion { get; set; }
        public bool? CsFresco { get; set; }
        public bool? Alinsa { get; set; }
        public string? TipoAlinsa { get; set; }
        public string? ProveedorAlinsa { get; set; }
        public string? ClaseDocEs { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public string? ControlInterno { get; set; }
        public string? SerieNumero { get; set; }

        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual DireccionEmbarque1? CodDirecEmbNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual Departamento1? DepartamentoNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual Proveedor1 ProveedorNavigation { get; set; } = null!;
        public virtual ResponSeguimiento1? ResponSeguimientoNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2? UsuarioCierreNavigation { get; set; }
        public virtual Usuario2? UsuarioConfirmaNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual ICollection<DetDocumentoOrden1> DetDocumentoOrden1s { get; set; }
        public virtual ICollection<OrdenCompraImp1> OrdenCompraImp1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<OrdenMovPre1> OrdenMovPre1s { get; set; }
        public virtual ICollection<UsuariosAprobOc1> UsuariosAprobOc1s { get; set; }
    }
}
