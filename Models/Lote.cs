using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Lote
    {
        public Lote()
        {
            BoletaInvFisicos = new HashSet<BoletaInvFisico>();
            ExistenciaLotes = new HashSet<ExistenciaLote>();
            ExistenciaReservas = new HashSet<ExistenciaReserva>();
            ExistenciaSeries = new HashSet<ExistenciaSerie>();
            FacturaLineas = new HashSet<FacturaLinea>();
            IngresosLotes = new HashSet<IngresosLote>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            LoteEspes = new HashSet<LoteEspe>();
            OrdenCompraLineas = new HashSet<OrdenCompraLinea>();
            PedidoLineas = new HashSet<PedidoLinea>();
            PedimentoLotes = new HashSet<PedimentoLote>();
            PistaExistenDets = new HashSet<PistaExistenDet>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string Lote1 { get; set; } = null!;
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

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicos { get; set; }
        public virtual ICollection<ExistenciaLote> ExistenciaLotes { get; set; }
        public virtual ICollection<ExistenciaReserva> ExistenciaReservas { get; set; }
        public virtual ICollection<ExistenciaSerie> ExistenciaSeries { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<IngresosLote> IngresosLotes { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<LoteEspe> LoteEspes { get; set; }
        public virtual ICollection<OrdenCompraLinea> OrdenCompraLineas { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<PedimentoLote> PedimentoLotes { get; set; }
        public virtual ICollection<PistaExistenDet> PistaExistenDets { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
