using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudOcLinea
    {
        public SolicitudOcLinea()
        {
            SolicitudOrdenCos = new HashSet<SolicitudOrdenCo>();
        }

        public string SolicitudOc { get; set; } = null!;
        public short SolicitudOcLinea1 { get; set; }
        public string? UsuarioCancela { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Saldo { get; set; }
        public string Estado { get; set; } = null!;
        public string? Comentario { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string? UnidadDistribucio { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public string? EMail { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public int? OrdenCambio { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? UPrecioUnitario { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual CentroCuentum? C { get; set; }
        public virtual SolicitudOc SolicitudOcNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum? UnidadDistribucioNavigation { get; set; }
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual ICollection<SolicitudOrdenCo> SolicitudOrdenCos { get; set; }
    }
}
