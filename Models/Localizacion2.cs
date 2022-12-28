using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Localizacion2
    {
        public Localizacion2()
        {
            BoletaInvFisico2s = new HashSet<BoletaInvFisico2>();
            DetLinEmbarque2s = new HashSet<DetLinEmbarque2>();
            DevolLinEmbarque2s = new HashSet<DevolLinEmbarque2>();
            ExistenciaLote2s = new HashSet<ExistenciaLote2>();
            ExistenciaReserva2s = new HashSet<ExistenciaReserva2>();
            ExistenciaSerie2s = new HashSet<ExistenciaSerie2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            LineaDocInv2Localizacion2Navigations = new HashSet<LineaDocInv2>();
            LineaDocInv2Localizacion2s = new HashSet<LineaDocInv2>();
            OrdenCompraLinea2s = new HashSet<OrdenCompraLinea2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            PistaExistenDet2s = new HashSet<PistaExistenDet2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
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

        public virtual Bodega2 BodegaNavigation { get; set; } = null!;
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2s { get; set; }
        public virtual ICollection<DetLinEmbarque2> DetLinEmbarque2s { get; set; }
        public virtual ICollection<DevolLinEmbarque2> DevolLinEmbarque2s { get; set; }
        public virtual ICollection<ExistenciaLote2> ExistenciaLote2s { get; set; }
        public virtual ICollection<ExistenciaReserva2> ExistenciaReserva2s { get; set; }
        public virtual ICollection<ExistenciaSerie2> ExistenciaSerie2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2Localizacion2Navigations { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2Localizacion2s { get; set; }
        public virtual ICollection<OrdenCompraLinea2> OrdenCompraLinea2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<PistaExistenDet2> PistaExistenDet2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
