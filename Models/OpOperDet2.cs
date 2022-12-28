using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDet2
    {
        public OpOperDet2()
        {
            OpConsumoProducc2s = new HashSet<OpConsumoProducc2>();
            OpOperDetDesper2s = new HashSet<OpOperDetDesper2>();
            OpOperDetMedic2s = new HashSet<OpOperDetMedic2>();
            OpOperDetMo2s = new HashSet<OpOperDetMo2>();
            OpOperDetProd2s = new HashSet<OpOperDetProd2>();
            OpOperParo2s = new HashSet<OpOperParo2>();
        }

        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public short Turno { get; set; }
        public string? Equipo { get; set; }
        public string? Empleado { get; set; }
        public decimal TipoDeCambio { get; set; }
        public decimal HorasMaq { get; set; }
        public decimal HorasMop { get; set; }
        public decimal HorasMoe { get; set; }
        public decimal? EmpMop { get; set; }
        public decimal? EmpMoe { get; set; }
        public decimal CantidadProducida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal CantidadTarjetas { get; set; }
        public string Contabilizada { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string? Notas { get; set; }
        public string? Aprobado { get; set; }
        public string? Asiento { get; set; }
        public decimal CostoMoLoc { get; set; }
        public decimal? CostoMoDol { get; set; }
        public decimal CostoGifLoc { get; set; }
        public decimal? CostoGifDol { get; set; }
        public decimal? VariacionMoLoc { get; set; }
        public decimal? VariacionMoDol { get; set; }
        public decimal? VariacionGifLoc { get; set; }
        public decimal? VariacionGifDol { get; set; }
        public string Origen { get; set; } = null!;
        public string ReportaProd { get; set; } = null!;
        public string ReportaMo { get; set; } = null!;
        public string ReportaGif { get; set; } = null!;
        public string ReportaConsumo { get; set; } = null!;
        public string? UsuarioAprob { get; set; }
        public DateTime? FechaHoraAprob { get; set; }
        public Guid? ReferenciaBackflush { get; set; }
        public string ProrrateoMo { get; set; } = null!;
        public string ProrrateoGif { get; set; } = null!;
        public string ProrrateoConsumo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperacion2 O { get; set; } = null!;
        public virtual Turno2 TurnoNavigation { get; set; } = null!;
        public virtual OpOperRef2 OpOperRef2 { get; set; } = null!;
        public virtual ICollection<OpConsumoProducc2> OpConsumoProducc2s { get; set; }
        public virtual ICollection<OpOperDetDesper2> OpOperDetDesper2s { get; set; }
        public virtual ICollection<OpOperDetMedic2> OpOperDetMedic2s { get; set; }
        public virtual ICollection<OpOperDetMo2> OpOperDetMo2s { get; set; }
        public virtual ICollection<OpOperDetProd2> OpOperDetProd2s { get; set; }
        public virtual ICollection<OpOperParo2> OpOperParo2s { get; set; }
    }
}
