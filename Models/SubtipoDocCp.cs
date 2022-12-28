using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCp
    {
        public SubtipoDocCp()
        {
            DocumentosCps = new HashSet<DocumentosCp>();
            LiquidacionPagos = new HashSet<LiquidacionPago>();
            ResolucionEs = new HashSet<ResolucionE>();
        }

        public short Subtipo { get; set; }
        public string Tipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? TipoCb { get; set; }
        public short? SubtipoCb { get; set; }
        public string? CuentaContable { get; set; }
        public string? CentroCosto { get; set; }
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
        public string? TipoPago { get; set; }
        public string? CodigoHacienda { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCb? SubtipoDocCb { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
        public virtual TipoPago? TipoPagoNavigation { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<LiquidacionPago> LiquidacionPagos { get; set; }
        public virtual ICollection<ResolucionE> ResolucionEs { get; set; }
    }
}
