using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCp2
    {
        public SubtipoDocCp2()
        {
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            LiquidacionPago2s = new HashSet<LiquidacionPago2>();
            ResolucionE2s = new HashSet<ResolucionE2>();
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

        public virtual CentroCuentum2? C { get; set; }
        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCb2? SubtipoDocCb2 { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
        public virtual TipoPago2? TipoPagoNavigation { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<LiquidacionPago2> LiquidacionPago2s { get; set; }
        public virtual ICollection<ResolucionE2> ResolucionE2s { get; set; }
    }
}
