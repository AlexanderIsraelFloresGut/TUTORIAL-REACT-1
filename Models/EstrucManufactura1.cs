using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucManufactura1
    {
        public EstrucManufactura1()
        {
            BomArticulo1s = new HashSet<BomArticulo1>();
            EstrucCliente1s = new HashSet<EstrucCliente1>();
            EstrucHistoric1s = new HashSet<EstrucHistoric1>();
            EstrucProceso1s = new HashSet<EstrucProceso1>();
            ManufacturaViewit1s = new HashSet<ManufacturaViewit1>();
            OrdenProduccion1s = new HashSet<OrdenProduccion1>();
        }

        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? NumCambioIng { get; set; }
        public string VersionAnterior { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime FechaProxRev { get; set; }
        public string RequeridaPor { get; set; } = null!;
        public DateTime? FechaRequerida { get; set; }
        public string ElaboradaPor { get; set; } = null!;
        public DateTime? FechaElaboracion { get; set; }
        public string CreadaPor { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string AprobadaPor { get; set; } = null!;
        public DateTime FechaAprobacion { get; set; }
        public decimal LoteEstandar { get; set; }
        public decimal LoteMultiplo { get; set; }
        public decimal LoteMinimo { get; set; }
        public decimal LoteMaximo { get; set; }
        public decimal CicloProdInicial { get; set; }
        public decimal CantProduccion { get; set; }
        public decimal HorasProduccion { get; set; }
        public decimal FactAprovecha { get; set; }
        public short UltimoNivel { get; set; }
        public string MetodoCosteoMop { get; set; } = null!;
        public string MetodoCosteoMoe { get; set; } = null!;
        public string MetodoCosteoGif { get; set; } = null!;
        public decimal CostoEstimMat { get; set; }
        public decimal CostoEstimMop { get; set; }
        public decimal CostoEstimMoe { get; set; }
        public decimal CostoEstimGif { get; set; }
        public decimal CostoOprodMat { get; set; }
        public decimal CostoOprodMop { get; set; }
        public decimal CostoOprodMoe { get; set; }
        public decimal CostoOprodGif { get; set; }
        public decimal TipoDeCambio { get; set; }
        public string? Referencia { get; set; }
        public string Seleccionada { get; set; } = null!;
        public string? Archivoviewit { get; set; }
        public string? Viewit { get; set; }
        public decimal PorcAjusteCosto { get; set; }
        public string PermiteBackflush { get; set; } = null!;
        public string AsigLotCrearOp { get; set; } = null!;
        public string RepProdSugLot { get; set; } = null!;
        public string NoSugLotes { get; set; } = null!;
        public string? TipConsecLotes { get; set; }
        public string? CentroCosto { get; set; }
        public string? PermiteCostoConta { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? DiasFabricMrp1 { get; set; }

        public virtual AliasProduccion1 ArticuloNavigation { get; set; } = null!;
        public virtual CentroCosto1? CentroCostoNavigation { get; set; }
        public virtual ManufacturMensaje1 ManufacturMensaje1 { get; set; } = null!;
        public virtual ManufacturaNota1 ManufacturaNota1 { get; set; } = null!;
        public virtual ICollection<BomArticulo1> BomArticulo1s { get; set; }
        public virtual ICollection<EstrucCliente1> EstrucCliente1s { get; set; }
        public virtual ICollection<EstrucHistoric1> EstrucHistoric1s { get; set; }
        public virtual ICollection<EstrucProceso1> EstrucProceso1s { get; set; }
        public virtual ICollection<ManufacturaViewit1> ManufacturaViewit1s { get; set; }
        public virtual ICollection<OrdenProduccion1> OrdenProduccion1s { get; set; }
    }
}
