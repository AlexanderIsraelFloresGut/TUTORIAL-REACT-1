using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoAutoriza
    {
        public string Pedido { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string? TipoDocumento { get; set; }
        public string? Factura { get; set; }
        public string LimCredito { get; set; } = null!;
        public string DocVencido { get; set; } = null!;
        public string CobroJudicial { get; set; } = null!;
        public string SinOc { get; set; } = null!;
        public string? Usuario { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Vigente { get; set; } = null!;
        public string Aprobada { get; set; } = null!;
        public string MargenArticulo { get; set; } = null!;
        public string ValorVentaMenor { get; set; } = null!;
        public string MontoMinimo { get; set; } = null!;
        public string DiasAtraso { get; set; } = null!;
        public string AprobadaVentas { get; set; } = null!;
        public string? UsuarioVentas { get; set; }
        public DateTime? FechaHoraVentas { get; set; }
        public string AprobadaCredito { get; set; } = null!;
        public DateTime? FechaHoraCredito { get; set; }
        public string? UsuarioCredito { get; set; }
        public string DctoGeneral { get; set; } = null!;
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Factura? FacturaNavigation { get; set; }
        public virtual Pedido PedidoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioNavigation { get; set; }
    }
}
