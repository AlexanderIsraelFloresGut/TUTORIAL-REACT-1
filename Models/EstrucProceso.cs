using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucProceso
    {
        public EstrucProceso()
        {
            EstrucMaterials = new HashSet<EstrucMaterial>();
            EstrucProcMos = new HashSet<EstrucProcMo>();
            EstrucProcRubros = new HashSet<EstrucProcRubro>();
            ProceHerramienta = new HashSet<ProceHerramientum>();
            ProcesoEnlaces = new HashSet<ProcesoEnlace>();
        }

        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CelulaTrabajo { get; set; } = null!;
        public string? Equipo { get; set; }
        public decimal FactAprovecha { get; set; }
        public string ReportaProd { get; set; } = null!;
        public decimal HorasStdMop { get; set; }
        public decimal HorasStdMoe { get; set; }
        public decimal HorasStdMaq { get; set; }
        public short EmpMop { get; set; }
        public short EmpMoe { get; set; }
        public string UnidProduccionPp { get; set; } = null!;
        public decimal CantProducidaPp { get; set; }
        public decimal CantProducidaPt { get; set; }
        public decimal CantCalidad { get; set; }
        public string? PoliticaKanBan { get; set; }
        public decimal? EquivalenciaKBan { get; set; }
        public decimal CostoMopHora { get; set; }
        public decimal CostoMoeHora { get; set; }
        public decimal CostoGifHora { get; set; }
        public decimal CostoMopUnidad { get; set; }
        public decimal CostoMoeUnidad { get; set; }
        public decimal CostoGifUnidad { get; set; }
        public decimal CostoEstimMat { get; set; }
        public decimal CostoEstimMop { get; set; }
        public decimal CostoEstimMoe { get; set; }
        public decimal CostoEstimGif { get; set; }
        public decimal CostoTranMat { get; set; }
        public decimal CostoTranMop { get; set; }
        public decimal CostoTranMoe { get; set; }
        public decimal CostoTranGif { get; set; }
        public decimal CostoOprodMat { get; set; }
        public decimal CostoOprodMop { get; set; }
        public decimal CostoOprodMoe { get; set; }
        public decimal CostoOprodGif { get; set; }
        public decimal PorcMop { get; set; }
        public decimal PorcMoe { get; set; }
        public decimal PorcGif { get; set; }
        public string? Notas { get; set; }
        public short? Secuencia { get; set; }
        public decimal HoraInicio { get; set; }
        public decimal HoraFin { get; set; }
        public decimal TiempoMaxEspera { get; set; }
        public decimal TiempoMinEspera { get; set; }
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
        public virtual EstrucManufactura EstrucManufactura { get; set; } = null!;
        public virtual ProcesoAlterno ProcesoAlterno { get; set; } = null!;
        public virtual ICollection<EstrucMaterial> EstrucMaterials { get; set; }
        public virtual ICollection<EstrucProcMo> EstrucProcMos { get; set; }
        public virtual ICollection<EstrucProcRubro> EstrucProcRubros { get; set; }
        public virtual ICollection<ProceHerramientum> ProceHerramienta { get; set; }
        public virtual ICollection<ProcesoEnlace> ProcesoEnlaces { get; set; }
    }
}
