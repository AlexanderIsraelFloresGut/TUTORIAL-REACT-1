using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCc
    {
        public SubtipoDocCc()
        {
            DocumentosCcs = new HashSet<DocumentosCc>();
            Facturas = new HashSet<Factura>();
            Pedidos = new HashSet<Pedido>();
        }

        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string? TipoCb { get; set; }
        public short? SubtipoCb { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? CentroCosto { get; set; }
        public string CalculaImp2 { get; set; } = null!;
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? TipoServicio { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? UTipoDoc { get; set; }
        public string? UConceptoNc { get; set; }
        public string? UConceptoFac { get; set; }
        public string? UConceptoNd { get; set; }
        public string? CodigoHacienda { get; set; }
        public string? UTipoOperacFac { get; set; }
        public string? UTipoOperacNc { get; set; }
        public string? UTipoOperacNd { get; set; }
        public string? TipoPago { get; set; }
        public string? ConsecutivoFac { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual ConsecutivoFa? ConsecutivoFacNavigation { get; set; }
        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCb? SubtipoDocCb { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
        public virtual TipoPago? TipoPagoNavigation { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
