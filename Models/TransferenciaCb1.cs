using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TransferenciaCb1
    {
        public TransferenciaCb1()
        {
            DetTransCb1s = new HashSet<DetTransCb1>();
        }

        public string CuentaOrigen { get; set; } = null!;
        public string TipoOrigen { get; set; } = null!;
        public decimal NumeroOrigen { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal? MontoComision { get; set; }
        public decimal MontoOrigen { get; set; }
        public string? Asiento { get; set; }
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime? FchHoraModific { get; set; }
        public string? UsuarioModific { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime? FechaAplicacion { get; set; }
        public string? Rubro1Trans { get; set; }
        public string? Rubro2Trans { get; set; }
        public string? Rubro3Trans { get; set; }
        public string? Rubro4Trans { get; set; }
        public string? Rubro5Trans { get; set; }
        public string? Rubro6Trans { get; set; }
        public string? Rubro7Trans { get; set; }
        public string? Rubro8Trans { get; set; }
        public string? Rubro9Trans { get; set; }
        public string? Rubro10Trans { get; set; }
        public string? DocumentoFiscal { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? MetodoPago { get; set; }

        public virtual MetodoPago1? MetodoPagoNavigation { get; set; }
        public virtual MovBanco1 MovBanco1 { get; set; } = null!;
        public virtual ICollection<DetTransCb1> DetTransCb1s { get; set; }
    }
}
