using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Embarque2
    {
        public Embarque2()
        {
            DetDocumentoEmbarque2s = new HashSet<DetDocumentoEmbarque2>();
            Devolucion2s = new HashSet<Devolucion2>();
            EmbarqueDocCp2s = new HashSet<EmbarqueDocCp2>();
            EmbarqueImp2s = new HashSet<EmbarqueImp2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            LiquidacGasto2s = new HashSet<LiquidacGasto2>();
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

        public virtual LiquidacCompra2? LiquidacCompraNavigation { get; set; }
        public virtual Pedimento2? PedimentoNavigation { get; set; }
        public virtual Proveedor2? ProveedorNavigation { get; set; }
        public virtual Usuario2? UsuarioAplicadoNavigation { get; set; }
        public virtual Usuario2 UsuarioCreadoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioLiquidacioNavigation { get; set; }
        public virtual ICollection<DetDocumentoEmbarque2> DetDocumentoEmbarque2s { get; set; }
        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<EmbarqueDocCp2> EmbarqueDocCp2s { get; set; }
        public virtual ICollection<EmbarqueImp2> EmbarqueImp2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<LiquidacGasto2> LiquidacGasto2s { get; set; }
    }
}
