using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacCompra
    {
        public LiquidacCompra()
        {
            DocumentosCps = new HashSet<DocumentosCp>();
            EmbarqueDocCps = new HashSet<EmbarqueDocCp>();
            Embarques = new HashSet<Embarque>();
            LiquidacDetalles = new HashSet<LiquidacDetalle>();
            LiquidacGastos = new HashSet<LiquidacGasto>();
        }

        public string LiquidacCompra1 { get; set; } = null!;
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

        public virtual Proveedor? ProveedorLiquidacNavigation { get; set; }
        public virtual LiquidacMensaje LiquidacMensaje { get; set; } = null!;
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<EmbarqueDocCp> EmbarqueDocCps { get; set; }
        public virtual ICollection<Embarque> Embarques { get; set; }
        public virtual ICollection<LiquidacDetalle> LiquidacDetalles { get; set; }
        public virtual ICollection<LiquidacGasto> LiquidacGastos { get; set; }
    }
}
