using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Embarque1
    {
        public Embarque1()
        {
            DetDocumentoEmbarque1s = new HashSet<DetDocumentoEmbarque1>();
            Devolucion1s = new HashSet<Devolucion1>();
            EmbarqueDocCp1s = new HashSet<EmbarqueDocCp1>();
            EmbarqueImp1s = new HashSet<EmbarqueImp1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            LiquidacGasto1s = new HashSet<LiquidacGasto1>();
        }

        public string Embarque { get; set; } = null!;
        public string? LiquidacCompra { get; set; }
        public string? Proveedor { get; set; }
        public string? Crm { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public DateTime? FechaOfrecida { get; set; }
        public DateTime? FechaEmbarque { get; set; }
        public DateTime? FechaAConsol { get; set; }
        public DateTime? FechaDesdeCons { get; set; }
        public DateTime? FechaAduana { get; set; }
        public DateTime? FechaAgencia { get; set; }
        public DateTime? FechaTramite { get; set; }
        public DateTime? FechaPlanta { get; set; }
        public string AsientoRecibo { get; set; } = null!;
        public string AsientoLiquidacio { get; set; } = null!;
        public string? Notas { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioCreado { get; set; } = null!;
        public DateTime FechaHoraCreado { get; set; }
        public string? UsuarioAplicado { get; set; }
        public DateTime? FechaHoraAplicac { get; set; }
        public string? Asiento { get; set; }
        public string Liquidado { get; set; } = null!;
        public DateTime? FechaHoraLiquida { get; set; }
        public string? UsuarioLiquidacio { get; set; }
        public string? AsientoLiq { get; set; }
        public int? AuditTransInv { get; set; }
        public int? AuditTransLiq { get; set; }
        public DateTime? FechaCrm { get; set; }
        public string? Referencia { get; set; }
        public string TieneFactura { get; set; } = null!;
        public string RecmasAfectaback { get; set; } = null!;
        public string DemasSepaga { get; set; } = null!;
        public string RecibidoDeMas { get; set; } = null!;
        public string? Pedimento { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? Multimoneda { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string UpdateLote { get; set; } = null!;

        public virtual LiquidacCompra1? LiquidacCompraNavigation { get; set; }
        public virtual Pedimento1? PedimentoNavigation { get; set; }
        public virtual Proveedor1? ProveedorNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicadoNavigation { get; set; }
        public virtual Usuario2 UsuarioCreadoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiquidacioNavigation { get; set; }
        public virtual ICollection<DetDocumentoEmbarque1> DetDocumentoEmbarque1s { get; set; }
        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<EmbarqueDocCp1> EmbarqueDocCp1s { get; set; }
        public virtual ICollection<EmbarqueImp1> EmbarqueImp1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<LiquidacGasto1> LiquidacGasto1s { get; set; }
    }
}
