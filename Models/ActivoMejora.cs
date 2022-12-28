using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoMejora
    {
        public ActivoMejora()
        {
            ActivoDesmantelamientos = new HashSet<ActivoDesmantelamiento>();
            ActivoHistRevals = new HashSet<ActivoHistReval>();
            DeprPorcentajes = new HashSet<DeprPorcentaje>();
            Equipos = new HashSet<Equipo>();
            HistDepreciacions = new HashSet<HistDepreciacion>();
            HistDeterioros = new HashSet<HistDeterioro>();
            ImpuestoActivos = new HashSet<ImpuestoActivo>();
        }

        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public string? Responsable { get; set; }
        public string Descripcion { get; set; } = null!;
        public int PlazoVidaUtil { get; set; }
        public int PlazoVidaComp { get; set; }
        public DateTime? FechaUltRevalF { get; set; }
        public DateTime? FechaUltRevalC { get; set; }
        public DateTime? FechaUltDeprF { get; set; }
        public DateTime? FechaUltDeprC { get; set; }
        public string TipoDeprFiscal { get; set; } = null!;
        public string TipoDeprComp { get; set; } = null!;
        public string TipoReval { get; set; } = null!;
        public string? TipoIndicePrecio { get; set; }
        public decimal PorcReval { get; set; }
        public decimal CostoOrigLocal { get; set; }
        public decimal CostoOrigDolar { get; set; }
        public decimal ValorRescLocalF { get; set; }
        public decimal ValorRescDolarF { get; set; }
        public decimal ValorRescLocalC { get; set; }
        public decimal ValorRescDolarC { get; set; }
        public decimal? MaxValorlibLocF { get; set; }
        public decimal? MaxValorlibDolF { get; set; }
        public decimal? MaxValorlibLocC { get; set; }
        public decimal? MaxValorlibDolC { get; set; }
        public decimal DepAcuHistLocF { get; set; }
        public decimal DepAcuHistDolF { get; set; }
        public decimal DepAcuHistLocC { get; set; }
        public decimal DepAcuHistDolC { get; set; }
        public decimal DepAcuRevaLocF { get; set; }
        public decimal DepAcuRevaDolF { get; set; }
        public decimal DepAcuRevaLocC { get; set; }
        public decimal DepAcuRevaDolC { get; set; }
        public decimal AcumRevalLocF { get; set; }
        public decimal AcumRevalDolF { get; set; }
        public decimal AcumRevalLocC { get; set; }
        public decimal AcumRevalDolC { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaActivacion { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string? UsuarioRetiro { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public string? Proveedor { get; set; }
        public string? CodigoBarras { get; set; }
        public string? NumeroSerie { get; set; }
        public string? AsientoIngreso { get; set; }
        public string? AsientoRetiroF { get; set; }
        public string? AsientoRetiroC { get; set; }
        public string? Notas { get; set; }
        public string? Rubro1Activo { get; set; }
        public string? Rubro2Activo { get; set; }
        public string? Rubro3Activo { get; set; }
        public string? Rubro4Activo { get; set; }
        public string? Rubro5Activo { get; set; }
        public string? Rubro6Activo { get; set; }
        public string? Rubro7Activo { get; set; }
        public string? Rubro8Activo { get; set; }
        public string? Rubro9Activo { get; set; }
        public string? Rubro10Activo { get; set; }
        public string? Rubro11Activo { get; set; }
        public string? Rubro12Activo { get; set; }
        public string? Rubro13Activo { get; set; }
        public string? Rubro14Activo { get; set; }
        public string? Rubro15Activo { get; set; }
        public string? DocumentoCp { get; set; }
        public string TipoRevalC { get; set; } = null!;
        public decimal? PorcRevalC { get; set; }
        public string? TipoIndicePrecioC { get; set; }
        public DateTime? FechaAudRetFisc { get; set; }
        public decimal CostoOrigComDolar { get; set; }
        public decimal CostoOrigComLocal { get; set; }
        public decimal? TasaReduccSaldosf { get; set; }
        public decimal? TasaReduccSaldosc { get; set; }
        public string? AsientoIngresoC { get; set; }
        public string Origen { get; set; } = null!;
        public string AjusteInflaF { get; set; } = null!;
        public string AjusteInflaC { get; set; } = null!;
        public string? Componente { get; set; }
        public decimal DepAcuAiLocF { get; set; }
        public decimal DepAcuAiLocC { get; set; }
        public decimal DepAcuAiDolF { get; set; }
        public decimal DepAcuAiDolC { get; set; }
        public string? ActivoOrigen { get; set; }
        public string? MejoraOrigen { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? AcumDeterioroLocC { get; set; }
        public decimal? AcumDeterioroDolC { get; set; }
        public decimal? AcumDeterioroLocF { get; set; }
        public decimal? AcumDeterioroDolF { get; set; }
        public DateTime? FechaUltDeterioro { get; set; }
        public DateTime? FechaUltDeterioroF { get; set; }
        public decimal? AcumDesmantelaLocC { get; set; }
        public decimal? AcumDesmantelaDolC { get; set; }
        public decimal? AcumDesmantelaLocF { get; set; }
        public decimal? AcumDesmantelaDolF { get; set; }
        public decimal? DepAcumDesmantelaLocC { get; set; }
        public decimal? DepAcumDesmantelaDolC { get; set; }
        public decimal? DepAcumDesmantelaLocF { get; set; }
        public decimal? DepAcumDesmantelaDolF { get; set; }
        public string? DesgloseImp { get; set; }
        public string EsIntangible { get; set; } = null!;

        public virtual ActivoFijo ActivoFijoNavigation { get; set; } = null!;
        public virtual Responsable? ResponsableNavigation { get; set; }
        public virtual TipoIndicePrecio? TipoIndicePrecioCNavigation { get; set; }
        public virtual TipoIndicePrecio? TipoIndicePrecioNavigation { get; set; }
        public virtual Usuario2? UsuarioRetiroNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ICollection<ActivoDesmantelamiento> ActivoDesmantelamientos { get; set; }
        public virtual ICollection<ActivoHistReval> ActivoHistRevals { get; set; }
        public virtual ICollection<DeprPorcentaje> DeprPorcentajes { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<HistDepreciacion> HistDepreciacions { get; set; }
        public virtual ICollection<HistDeterioro> HistDeterioros { get; set; }
        public virtual ICollection<ImpuestoActivo> ImpuestoActivos { get; set; }
    }
}
