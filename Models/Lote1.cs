using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Lote1
    {
        public Lote1()
        {
            BoletaInvFisico1s = new HashSet<BoletaInvFisico1>();
            ExistenciaLote1s = new HashSet<ExistenciaLote1>();
            ExistenciaReserva1s = new HashSet<ExistenciaReserva1>();
            ExistenciaSerie1s = new HashSet<ExistenciaSerie1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            IngresosLote1s = new HashSet<IngresosLote1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            LoteEspe1s = new HashSet<LoteEspe1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            PedimentoLote1s = new HashSet<PedimentoLote1>();
            PistaExistenDet1s = new HashSet<PistaExistenDet1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
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

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Proveedor1? ProveedorNavigation { get; set; }
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1s { get; set; }
        public virtual ICollection<ExistenciaLote1> ExistenciaLote1s { get; set; }
        public virtual ICollection<ExistenciaReserva1> ExistenciaReserva1s { get; set; }
        public virtual ICollection<ExistenciaSerie1> ExistenciaSerie1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<IngresosLote1> IngresosLote1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<LoteEspe1> LoteEspe1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<PedimentoLote1> PedimentoLote1s { get; set; }
        public virtual ICollection<PistaExistenDet1> PistaExistenDet1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
