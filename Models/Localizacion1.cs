using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Localizacion1
    {
        public Localizacion1()
        {
            BoletaInvFisico1s = new HashSet<BoletaInvFisico1>();
            DetLinEmbarque1s = new HashSet<DetLinEmbarque1>();
            DevolLinEmbarque1s = new HashSet<DevolLinEmbarque1>();
            ExistenciaLote1s = new HashSet<ExistenciaLote1>();
            ExistenciaReserva1s = new HashSet<ExistenciaReserva1>();
            ExistenciaSerie1s = new HashSet<ExistenciaSerie1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            LineaDocInv1Localizacion1Navigations = new HashSet<LineaDocInv1>();
            LineaDocInv1Localizacion1s = new HashSet<LineaDocInv1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            PistaExistenDet1s = new HashSet<PistaExistenDet1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
        }

        public string Bodega { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Volumen { get; set; }
        public decimal PesoMaximo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1s { get; set; }
        public virtual ICollection<DetLinEmbarque1> DetLinEmbarque1s { get; set; }
        public virtual ICollection<DevolLinEmbarque1> DevolLinEmbarque1s { get; set; }
        public virtual ICollection<ExistenciaLote1> ExistenciaLote1s { get; set; }
        public virtual ICollection<ExistenciaReserva1> ExistenciaReserva1s { get; set; }
        public virtual ICollection<ExistenciaSerie1> ExistenciaSerie1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1Localizacion1Navigations { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1Localizacion1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<PistaExistenDet1> PistaExistenDet1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
