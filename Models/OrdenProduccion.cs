using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OrdenProduccion
    {
        public OrdenProduccion()
        {
            OpOperacions = new HashSet<OpOperacion>();
            OrdenClientes = new HashSet<OrdenCliente>();
            OrdenViewits = new HashSet<OrdenViewit>();
            PedidoOrdenProducs = new HashSet<PedidoOrdenProduc>();
            Requisicions = new HashSet<Requisicion>();
        }

        public string OrdenProduccion1 { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public decimal CantidadArticulo { get; set; }
        public string Tipo { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public short Prioridad { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public DateTime FechaALiberar { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string BodegaPt { get; set; } = null!;
        public string Contabilizada { get; set; } = null!;
        public decimal CostoEstimMat { get; set; }
        public decimal CostoEstimMop { get; set; }
        public decimal CostoEstimMoe { get; set; }
        public decimal CostoEstimGif { get; set; }
        public decimal CostoEstimOpMat { get; set; }
        public decimal CostoEstimOpMop { get; set; }
        public decimal CostoEstimOpMoe { get; set; }
        public decimal CostoEstimOpGif { get; set; }
        public decimal TipoDeCambio { get; set; }
        public decimal CostoRealMatL { get; set; }
        public decimal CostoRealMopL { get; set; }
        public decimal CostoRealMoeL { get; set; }
        public decimal CostoRealGifL { get; set; }
        public decimal CostoRealOpmatL { get; set; }
        public decimal CostoRealOpmopL { get; set; }
        public decimal CostoRealOpmoeL { get; set; }
        public decimal CostoRealOpgifL { get; set; }
        public decimal CostoRealMatD { get; set; }
        public decimal CostoRealMopD { get; set; }
        public decimal CostoRealMoeD { get; set; }
        public decimal CostoRealGifD { get; set; }
        public decimal CostoRealOpmatD { get; set; }
        public decimal CostoRealOpmopD { get; set; }
        public decimal CostoRealOpmoeD { get; set; }
        public decimal CostoRealOpgifD { get; set; }
        public decimal CostoInventarioL { get; set; }
        public decimal CostoInventarioD { get; set; }
        public decimal VariacionCosto { get; set; }
        public string? Archivoviewit { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FechaLiberacion { get; set; }
        public string? UsuarioLiberacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string? UsuarioCierre { get; set; }
        public DateTime? FechaHoraCosteo { get; set; }
        public DateTime? FechaHoraUltAct { get; set; }
        public string? Viewit { get; set; }
        public string? Seleccionada { get; set; }
        public string? EstructuraModific { get; set; }
        public string BodegaMp { get; set; } = null!;
        public decimal? PorcAjusteCosto { get; set; }
        public string? AsientoLiquida { get; set; }
        public decimal? Duracion { get; set; }
        public DateTime? FechaTerminada { get; set; }
        public string? CostoIngresoPt { get; set; }
        public string? UsuarioPrecierre { get; set; }
        public DateTime? FechaHoraPrecierre { get; set; }
        public string? UsuarioCancela { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public DateTime? FechaCierreConta { get; set; }
        public string? Referencia { get; set; }
        public string? LoteProd { get; set; }
        public string? CentroCosto { get; set; }
        public string PermitirMovimientoOrden { get; set; } = null!;
        public string? PermiteCostoConta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega BodegaMpNavigation { get; set; } = null!;
        public virtual Bodega BodegaPtNavigation { get; set; } = null!;
        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual EstrucManufactura EstrucManufactura { get; set; } = null!;
        public virtual OrdenMensaje OrdenMensaje { get; set; } = null!;
        public virtual OrdenNota OrdenNota { get; set; } = null!;
        public virtual ICollection<OpOperacion> OpOperacions { get; set; }
        public virtual ICollection<OrdenCliente> OrdenClientes { get; set; }
        public virtual ICollection<OrdenViewit> OrdenViewits { get; set; }
        public virtual ICollection<PedidoOrdenProduc> PedidoOrdenProducs { get; set; }
        public virtual ICollection<Requisicion> Requisicions { get; set; }
    }
}
