using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacCompra2
    {
        public LiquidacCompra2()
        {
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Embarque2s = new HashSet<Embarque2>();
            EmbarqueDocCp2s = new HashSet<EmbarqueDocCp2>();
            LiquidacDetalle2s = new HashSet<LiquidacDetalle2>();
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
        }

        public string LiquidacCompra { get; set; } = null!;
        public string? ProveedorLiquidac { get; set; }
        public string EstadoLiquidac { get; set; } = null!;
        public DateTime FechaLiquidac { get; set; }
        public string? ReferenciaLiquid { get; set; }
        public string ProrrateoLiquidac { get; set; } = null!;
        public decimal? TipoCambioDolar { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaHoraCreac { get; set; }
        public string? UsuarioCalculo { get; set; }
        public DateTime? FechaHoraCalculo { get; set; }
        public string? UsuarioUltModif { get; set; }
        public DateTime? FecHoraUltModif { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaHoraAprobac { get; set; }
        public string? UsuarioCancela { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public string? Notas { get; set; }
        public string CalculaArancel { get; set; } = null!;
        public decimal? MontoFleteLocal { get; set; }
        public decimal? MontoFleteDolar { get; set; }
        public decimal? MontoSeguroLocal { get; set; }
        public decimal? MontoSeguroDolar { get; set; }
        public decimal? MontoOtrosLocal { get; set; }
        public decimal? MontoOtrosDolar { get; set; }
        public decimal? ImpRealLocal { get; set; }
        public decimal? ImpRealDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Proveedor2? ProveedorLiquidacNavigation { get; set; }
        public virtual LiquidacMensaje2 LiquidacMensaje2 { get; set; } = null!;
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Embarque2> Embarque2s { get; set; }
        public virtual ICollection<EmbarqueDocCp2> EmbarqueDocCp2s { get; set; }
        public virtual ICollection<LiquidacDetalle2> LiquidacDetalle2s { get; set; }
        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
    }
}
