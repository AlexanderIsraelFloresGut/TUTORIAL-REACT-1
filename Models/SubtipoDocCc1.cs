using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCc1
    {
        public SubtipoDocCc1()
        {
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            Factura1s = new HashSet<Factura1>();
            Pedido1s = new HashSet<Pedido1>();
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
        public string? UConceptoNc { get; set; }
        public string? UConceptoFac { get; set; }
        public string? UConceptoNd { get; set; }
        public string? CodigoHacienda { get; set; }
        public string? UTipoOperacFac { get; set; }
        public string? UTipoOperacNc { get; set; }
        public string? UTipoOperacNd { get; set; }
        public string? TipoPago { get; set; }
        public string? ConsecutivoFac { get; set; }
        public string? TipoCambio { get; set; }
        public string ParticipaSemt { get; set; } = null!;
        public string? TipoDocumento { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual ConsecutivoFa1? ConsecutivoFacNavigation { get; set; }
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCb1? SubtipoDocCb1 { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual TipoCambio1? TipoCambioNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
    }
}
