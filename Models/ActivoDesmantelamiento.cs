using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoDesmantelamiento
    {
        public string Desmantelamiento { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public DateTime? FechaAdquisicion { get; set; }
        public DateTime? FechaActivacion { get; set; }
        public string? Proveedor { get; set; }
        public string? OrdenCompra { get; set; }
        public string? DocumentoCp { get; set; }
        public string? NumeroSerie { get; set; }
        public string? CodigoBarras { get; set; }
        public decimal CostoOrigFisLocal { get; set; }
        public decimal CostoOrigFisDolar { get; set; }
        public decimal CostoOrigComLocal { get; set; }
        public decimal CostoOrigComDolar { get; set; }
        public decimal ValorRescLocalF { get; set; }
        public decimal ValorRescDolarF { get; set; }
        public decimal ValorRescLocalC { get; set; }
        public decimal ValorRescDolarC { get; set; }
        public decimal? MaxValorlibLocF { get; set; }
        public decimal? MaxValorlibDolF { get; set; }
        public decimal? MaxValorlibLocC { get; set; }
        public decimal? MaxValorlibDolC { get; set; }
        public string TipoDeprFis { get; set; } = null!;
        public string TipoDeprComp { get; set; } = null!;
        public decimal? TasaReduccSaldo { get; set; }
        public decimal? TasaReduccSaldoF { get; set; }
        public short PlazoVidaUtilF { get; set; }
        public short PlazoVidaUtil { get; set; }
        public string TipoRevalF { get; set; } = null!;
        public string TipoRevalC { get; set; } = null!;
        public decimal? PorcRevalF { get; set; }
        public decimal? PorcReval { get; set; }
        public string? TipoIndicePrecioF { get; set; }
        public string? TipoIndicePrecio { get; set; }
        public string Origen { get; set; } = null!;
        public DateTime? FechaUltDepreF { get; set; }
        public DateTime? FechaUltDepre { get; set; }
        public DateTime? FechaUltRevalF { get; set; }
        public DateTime? FechaUltReval { get; set; }
        public decimal? AcumDeterioroLocF { get; set; }
        public decimal? AcumDeterioroDolF { get; set; }
        public decimal? AcumDeterioroLocC { get; set; }
        public decimal? AcumDeterioroDolC { get; set; }
        public decimal? AcumRevalLocF { get; set; }
        public decimal? AcumRevalDolF { get; set; }
        public decimal? AcumRevalLocC { get; set; }
        public decimal? AcumRevalDolC { get; set; }
        public decimal? DepAcumRevalLocC { get; set; }
        public decimal? DepAcumRevalDolC { get; set; }
        public decimal? DepAcumRevalLocF { get; set; }
        public decimal? DepAcumRevalDolF { get; set; }
        public decimal? DepAcumDesmantelaLocC { get; set; }
        public decimal? DepAcumDesmantelaDolC { get; set; }
        public decimal? DepAcumDesmantelaLocF { get; set; }
        public decimal? DepAcumDesmantelaDolF { get; set; }
        public string? Notas { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FechaUltMod { get; set; }
        public string? UsuarioRetiro { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string? AsientoIngresoF { get; set; }
        public string? AsientoIngreso { get; set; }
        public string? AsientoRetiroF { get; set; }
        public string? AsientoRetiroC { get; set; }
        public string EsIntangible { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoMejora ActivoMejora { get; set; } = null!;
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual TipoIndicePrecio? TipoIndicePrecioFNavigation { get; set; }
        public virtual TipoIndicePrecio? TipoIndicePrecioNavigation { get; set; }
        public virtual Usuario2? UsuarioRetiroNavigation { get; set; }
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
    }
}
