using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDet
    {
        public OpOperDet()
        {
            OpConsumoProduccs = new HashSet<OpConsumoProducc>();
            OpOperDetDespers = new HashSet<OpOperDetDesper>();
            OpOperDetMedics = new HashSet<OpOperDetMedic>();
            OpOperDetMos = new HashSet<OpOperDetMo>();
            OpOperDetProds = new HashSet<OpOperDetProd>();
            OpOperParos = new HashSet<OpOperParo>();
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

        public virtual Equipo? EquipoNavigation { get; set; }
        public virtual OpOperacion O { get; set; } = null!;
        public virtual Turno TurnoNavigation { get; set; } = null!;
        public virtual OpOperRef OpOperRef { get; set; } = null!;
        public virtual ICollection<OpConsumoProducc> OpConsumoProduccs { get; set; }
        public virtual ICollection<OpOperDetDesper> OpOperDetDespers { get; set; }
        public virtual ICollection<OpOperDetMedic> OpOperDetMedics { get; set; }
        public virtual ICollection<OpOperDetMo> OpOperDetMos { get; set; }
        public virtual ICollection<OpOperDetProd> OpOperDetProds { get; set; }
        public virtual ICollection<OpOperParo> OpOperParos { get; set; }
    }
}
