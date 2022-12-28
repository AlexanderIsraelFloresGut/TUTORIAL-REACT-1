using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Localizacion
    {
        public Localizacion()
        {
            BoletaInvFisicos = new HashSet<BoletaInvFisico>();
            DetLinEmbarques = new HashSet<DetLinEmbarque>();
            DevolLinEmbarques = new HashSet<DevolLinEmbarque>();
            ExistenciaLotes = new HashSet<ExistenciaLote>();
            ExistenciaReservas = new HashSet<ExistenciaReserva>();
            ExistenciaSeries = new HashSet<ExistenciaSerie>();
            FacturaLineas = new HashSet<FacturaLinea>();
            LineaDocInvLocalizacion1s = new HashSet<LineaDocInv>();
            LineaDocInvLocalizacionNavigations = new HashSet<LineaDocInv>();
            OrdenCompraLineas = new HashSet<OrdenCompraLinea>();
            PedidoLineas = new HashSet<PedidoLinea>();
            PistaExistenDets = new HashSet<PistaExistenDet>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public string Bodega { get; set; } = null!;
        public string Localizacion1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Volumen { get; set; }
        public decimal PesoMaximo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicos { get; set; }
        public virtual ICollection<DetLinEmbarque> DetLinEmbarques { get; set; }
        public virtual ICollection<DevolLinEmbarque> DevolLinEmbarques { get; set; }
        public virtual ICollection<ExistenciaLote> ExistenciaLotes { get; set; }
        public virtual ICollection<ExistenciaReserva> ExistenciaReservas { get; set; }
        public virtual ICollection<ExistenciaSerie> ExistenciaSeries { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvLocalizacion1s { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvLocalizacionNavigations { get; set; }
        public virtual ICollection<OrdenCompraLinea> OrdenCompraLineas { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<PistaExistenDet> PistaExistenDets { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
