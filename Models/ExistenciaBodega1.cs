using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExistenciaBodega1
    {
        public ExistenciaBodega1()
        {
            ExistenciaLote1s = new HashSet<ExistenciaLote1>();
            ExistenciaReserva1s = new HashSet<ExistenciaReserva1>();
            ExistenciaSerie1s = new HashSet<ExistenciaSerie1>();
            PistaExistenDet1s = new HashSet<PistaExistenDet1>();
        }

        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal ExistenciaMinima { get; set; }
        public decimal ExistenciaMaxima { get; set; }
        public decimal PuntoDeReorden { get; set; }
        public decimal CantDisponible { get; set; }
        public decimal CantReservada { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public decimal CantTransito { get; set; }
        public decimal CantProduccion { get; set; }
        public decimal CantPedida { get; set; }
        public decimal CantRemitida { get; set; }
        public string Congelado { get; set; } = null!;
        public DateTime? FechaCong { get; set; }
        public string BloqueaTrans { get; set; } = null!;
        public DateTime? FechaDescong { get; set; }
        public decimal CostoUntPromedioLoc { get; set; }
        public decimal CostoUntPromedioDol { get; set; }
        public decimal CostoUntEstandarLoc { get; set; }
        public decimal CostoUntEstandarDol { get; set; }
        public decimal CostoPromComparativoLoc { get; set; }
        public decimal CostoPromComparativoDolar { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega1 BodegaNavigation { get; set; } = null!;
        public virtual ICollection<ExistenciaLote1> ExistenciaLote1s { get; set; }
        public virtual ICollection<ExistenciaReserva1> ExistenciaReserva1s { get; set; }
        public virtual ICollection<ExistenciaSerie1> ExistenciaSerie1s { get; set; }
        public virtual ICollection<PistaExistenDet1> PistaExistenDet1s { get; set; }
    }
}
