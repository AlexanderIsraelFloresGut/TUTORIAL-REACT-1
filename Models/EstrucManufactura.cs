using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucManufactura
    {
        public EstrucManufactura()
        {
            BomArticulos = new HashSet<BomArticulo>();
            EstrucClientes = new HashSet<EstrucCliente>();
            EstrucHistorics = new HashSet<EstrucHistoric>();
            EstrucProcesos = new HashSet<EstrucProceso>();
            ManufacturaViewits = new HashSet<ManufacturaViewit>();
            OrdenProduccions = new HashSet<OrdenProduccion>();
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

        public virtual AliasProduccion ArticuloNavigation { get; set; } = null!;
        public virtual CentroCosto? CentroCostoNavigation { get; set; }
        public virtual ManufacturMensaje ManufacturMensaje { get; set; } = null!;
        public virtual ManufacturaNota ManufacturaNota { get; set; } = null!;
        public virtual ICollection<BomArticulo> BomArticulos { get; set; }
        public virtual ICollection<EstrucCliente> EstrucClientes { get; set; }
        public virtual ICollection<EstrucHistoric> EstrucHistorics { get; set; }
        public virtual ICollection<EstrucProceso> EstrucProcesos { get; set; }
        public virtual ICollection<ManufacturaViewit> ManufacturaViewits { get; set; }
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }
    }
}
