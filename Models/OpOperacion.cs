using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperacion
    {
        public OpOperacion()
        {
            OpOperConsumos = new HashSet<OpOperConsumo>();
            OpOperContLiqs = new HashSet<OpOperContLiq>();
            OpOperCostAuxes = new HashSet<OpOperCostAux>();
            OpOperDets = new HashSet<OpOperDet>();
            OpOperEnlaces = new HashSet<OpOperEnlace>();
            OpOperProds = new HashSet<OpOperProd>();
            OpOperVarios = new HashSet<OpOperVario>();
            OpOperacionMos = new HashSet<OpOperacionMo>();
            OpOperacionRubros = new HashSet<OpOperacionRubro>();
        }

        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string? Equipo { get; set; }
        public string? EquipoSimulacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string CelulaTrabajo { get; set; } = null!;
        public string Activa { get; set; } = null!;
        public decimal CantProducidaPp { get; set; }
        public decimal CantProducidaPt { get; set; }
        public decimal EquivalKanBan { get; set; }
        public string ReportaProd { get; set; } = null!;
        public decimal CostoStdMop { get; set; }
        public decimal CostoStdMoe { get; set; }
        public decimal CostoStdGif { get; set; }
        public decimal HorasStdMop { get; set; }
        public decimal HorasStdMoe { get; set; }
        public decimal HorasStdMaq { get; set; }
        public short EmpStdMop { get; set; }
        public short EmpStdMoe { get; set; }
        public decimal CostoEstimMat { get; set; }
        public decimal CostoEstimMop { get; set; }
        public decimal CostoEstimMoe { get; set; }
        public decimal CostoEstimGif { get; set; }
        public decimal CostoEstimOpMat { get; set; }
        public decimal CostoEstimOpMop { get; set; }
        public decimal CostoEstimOpMoe { get; set; }
        public decimal CostoEstimOpGif { get; set; }
        public decimal CostoEstimTrMat { get; set; }
        public decimal CostoEstimTrMop { get; set; }
        public decimal CostoEstimTrMoe { get; set; }
        public decimal CostoEstimTrGif { get; set; }
        public decimal CantidadProducida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal CostoRealMatL { get; set; }
        public decimal CostoRealMopL { get; set; }
        public decimal CostoRealMoeL { get; set; }
        public decimal CostoRealGifL { get; set; }
        public decimal CostoRealOpmatL { get; set; }
        public decimal CostoRealOpmopL { get; set; }
        public decimal CostoRealOpmoeL { get; set; }
        public decimal CostoRealOpgifL { get; set; }
        public decimal CostoRealTrmatL { get; set; }
        public decimal CostoRealTrmopL { get; set; }
        public decimal CostoRealTrmoeL { get; set; }
        public decimal CostoRealTrgifL { get; set; }
        public decimal CostoRealMatD { get; set; }
        public decimal CostoRealMopD { get; set; }
        public decimal CostoRealMoeD { get; set; }
        public decimal CostoRealGifD { get; set; }
        public decimal CostoRealOpmatD { get; set; }
        public decimal CostoRealOpmopD { get; set; }
        public decimal CostoRealOpmoeD { get; set; }
        public decimal CostoRealOpgifD { get; set; }
        public decimal CostoRealTrmatD { get; set; }
        public decimal CostoRealTrmopD { get; set; }
        public decimal CostoRealTrmoeD { get; set; }
        public decimal CostoRealTrgifD { get; set; }
        public decimal HorasRealMop { get; set; }
        public decimal HorasRealMoe { get; set; }
        public decimal HorasRealMaq { get; set; }
        public decimal EmpRealMop { get; set; }
        public decimal EmpRealMoe { get; set; }
        public string? PoliticaKanBan { get; set; }
        public string? Notas { get; set; }
        public short? Secuencia { get; set; }
        public string Estado { get; set; } = null!;
        public decimal HoraInicio { get; set; }
        public decimal HoraFin { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraIniSim { get; set; }
        public DateTime FechaHoraFinSim { get; set; }
        public decimal TiempoMaxEspera { get; set; }
        public decimal TiempoMinEspera { get; set; }
        public string? UnidProduccionPp { get; set; }
        public string ReportaMo { get; set; } = null!;
        public string ReportaGif { get; set; } = null!;
        public string ReportaConsumo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CelulaTrabajo CelulaTrabajoNavigation { get; set; } = null!;
        public virtual Equipo? EquipoNavigation { get; set; }
        public virtual Equipo? EquipoSimulacionNavigation { get; set; }
        public virtual OrdenProduccion OrdenProduccionNavigation { get; set; } = null!;
        public virtual UnidadDeMedidum? UnidProduccionPpNavigation { get; set; }
        public virtual ICollection<OpOperConsumo> OpOperConsumos { get; set; }
        public virtual ICollection<OpOperContLiq> OpOperContLiqs { get; set; }
        public virtual ICollection<OpOperCostAux> OpOperCostAuxes { get; set; }
        public virtual ICollection<OpOperDet> OpOperDets { get; set; }
        public virtual ICollection<OpOperEnlace> OpOperEnlaces { get; set; }
        public virtual ICollection<OpOperProd> OpOperProds { get; set; }
        public virtual ICollection<OpOperVario> OpOperVarios { get; set; }
        public virtual ICollection<OpOperacionMo> OpOperacionMos { get; set; }
        public virtual ICollection<OpOperacionRubro> OpOperacionRubros { get; set; }
    }
}
