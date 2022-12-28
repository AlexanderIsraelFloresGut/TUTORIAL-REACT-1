using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Lote2
    {
        public Lote2()
        {
            BoletaInvFisico2s = new HashSet<BoletaInvFisico2>();
            ExistenciaLote2s = new HashSet<ExistenciaLote2>();
            ExistenciaReserva2s = new HashSet<ExistenciaReserva2>();
            ExistenciaSerie2s = new HashSet<ExistenciaSerie2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            IngresosLote2s = new HashSet<IngresosLote2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            LoteEspe2s = new HashSet<LoteEspe2>();
            OrdenCompraLinea2s = new HashSet<OrdenCompraLinea2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            PedimentoLote2s = new HashSet<PedimentoLote2>();
            PistaExistenDet2s = new HashSet<PistaExistenDet2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public string Lote { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Proveedor { get; set; }
        public string? LoteDelProveedor { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCuarentena { get; set; }
        public decimal CantidadIngresada { get; set; }
        public string Estado { get; set; } = null!;
        public string TipoIngreso { get; set; } = null!;
        public string? Notas { get; set; }
        public int UltimoIngreso { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaFabricacion { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Proveedor2? ProveedorNavigation { get; set; }
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2s { get; set; }
        public virtual ICollection<ExistenciaLote2> ExistenciaLote2s { get; set; }
        public virtual ICollection<ExistenciaReserva2> ExistenciaReserva2s { get; set; }
        public virtual ICollection<ExistenciaSerie2> ExistenciaSerie2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<IngresosLote2> IngresosLote2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<LoteEspe2> LoteEspe2s { get; set; }
        public virtual ICollection<OrdenCompraLinea2> OrdenCompraLinea2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<PedimentoLote2> PedimentoLote2s { get; set; }
        public virtual ICollection<PistaExistenDet2> PistaExistenDet2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
