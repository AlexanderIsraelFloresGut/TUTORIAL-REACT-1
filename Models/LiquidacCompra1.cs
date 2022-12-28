using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacCompra1
    {
        public LiquidacCompra1()
        {
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Embarque1s = new HashSet<Embarque1>();
            EmbarqueDocCp1s = new HashSet<EmbarqueDocCp1>();
            LiquidacDetalle1s = new HashSet<LiquidacDetalle1>();
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
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

        public virtual Proveedor1? ProveedorLiquidacNavigation { get; set; }
        public virtual LiquidacMensaje1 LiquidacMensaje1 { get; set; } = null!;
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Embarque1> Embarque1s { get; set; }
        public virtual ICollection<EmbarqueDocCp1> EmbarqueDocCp1s { get; set; }
        public virtual ICollection<LiquidacDetalle1> LiquidacDetalle1s { get; set; }
        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
    }
}
