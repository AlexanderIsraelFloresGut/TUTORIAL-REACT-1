using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoSugerido2
    {
        public string Proveedor { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public DateTime FechaHoraGenerac { get; set; }
        public string Estado { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public decimal ConsumoPromedio { get; set; }
        public decimal InventarioActual { get; set; }
        public decimal InventarioMaximo { get; set; }
        public decimal InventarioTransit { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ReferenciaPedido { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal CantidadSugerida { get; set; }
        public decimal CantSugAjustada { get; set; }
        public string UsuarioGeneracion { get; set; } = null!;
        public string? UsuarioSolicitud { get; set; }
        public DateTime? FechaHoraSolicit { get; set; }
        public string? SolicitudOc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Clasificacion2? Clasificacion1Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion2Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion3Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion4Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion5Navigation { get; set; }
        public virtual Clasificacion2? Clasificacion6Navigation { get; set; }
        public virtual Proveedor2 ProveedorNavigation { get; set; } = null!;
        public virtual SolicitudOc2? SolicitudOcNavigation { get; set; }
        public virtual Usuario2 UsuarioGeneracionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioSolicitudNavigation { get; set; }
    }
}
