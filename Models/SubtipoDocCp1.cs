using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCp1
    {
        public SubtipoDocCp1()
        {
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            LiquidacionPago1s = new HashSet<LiquidacionPago1>();
            ResolucionE1s = new HashSet<ResolucionE1>();
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
        public string? TipoCambio { get; set; }
        public string ParticipaSemt { get; set; } = null!;
        public string? TipoDocumento { get; set; }

        public virtual CentroCuentum1? C { get; set; }
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual SubtipoDocCb1? SubtipoDocCb1 { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual TipoCambio1? TipoCambioNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<LiquidacionPago1> LiquidacionPago1s { get; set; }
        public virtual ICollection<ResolucionE1> ResolucionE1s { get; set; }
    }
}
