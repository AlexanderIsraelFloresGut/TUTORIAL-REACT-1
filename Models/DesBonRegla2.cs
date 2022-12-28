using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonRegla2
    {
        public DesBonRegla2()
        {
            DesBonEscalaBonificacion2s = new HashSet<DesBonEscalaBonificacion2>();
            DesBonEspecificacionGrupo2s = new HashSet<DesBonEspecificacionGrupo2>();
            DesBonPaqueteRegla2s = new HashSet<DesBonPaqueteRegla2>();
            DesBonReglaLote2s = new HashSet<DesBonReglaLote2>();
        }

        public string Regla { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Activa { get; set; } = null!;
        public string? FiltroCliente { get; set; }
        public string ValidarCantidad { get; set; } = null!;
        public decimal? CantidadMinima { get; set; }
        public decimal? CantidadMaxima { get; set; }
        public string? FiltroArticulo { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public string TipoValor { get; set; } = null!;
        public decimal? Valor { get; set; }
        public string TipoBonificacion { get; set; } = null!;
        public string UtilizarArticuloLinea { get; set; } = null!;
        public string? FiltroArticuloBonificacion { get; set; }
        public string AplicacionGrupos { get; set; } = null!;
        public int? Prioridad { get; set; }
        public decimal MontoMinimo { get; set; }
        public string? CategoriaMembresia { get; set; }
        public string? FormaPago { get; set; }
        public string? DetalleFormaPago { get; set; }
        public decimal? MinimoPago { get; set; }
        public string RequiereAutorizacion { get; set; } = null!;
        public decimal? CantidadMinDetalle { get; set; }
        public decimal? CantidadMaxDetalle { get; set; }
        public decimal? CantidadAlmacenCompra { get; set; }
        public decimal? CantidadAlmacenDescontar { get; set; }
        public decimal? CantidadDetalleCompra { get; set; }
        public decimal? CantidadDetalleDescontar { get; set; }
        public string AplicaArticuloMenorPrecio { get; set; } = null!;
        public string AgrupacionArticulo { get; set; } = null!;
        public string? FiltroLote { get; set; }
        public string TipoReglaLote { get; set; } = null!;
        public decimal? MontoDesde { get; set; }
        public decimal? MontoHasta { get; set; }
        public decimal CantidadLimite { get; set; }
        public string EspecificacionGrupo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DesBonEscalaBonificacion2> DesBonEscalaBonificacion2s { get; set; }
        public virtual ICollection<DesBonEspecificacionGrupo2> DesBonEspecificacionGrupo2s { get; set; }
        public virtual ICollection<DesBonPaqueteRegla2> DesBonPaqueteRegla2s { get; set; }
        public virtual ICollection<DesBonReglaLote2> DesBonReglaLote2s { get; set; }
    }
}
