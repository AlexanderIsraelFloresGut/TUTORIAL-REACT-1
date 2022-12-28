using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Formato2
    {
        public Formato2()
        {
            FormatoColumna2s = new HashSet<FormatoColumna2>();
            FormatoOrden2s = new HashSet<FormatoOrden2>();
            FormatoUsuario2s = new HashSet<FormatoUsuario2>();
        }

        public string Formato { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string FuenteDatos { get; set; } = null!;
        public string TipoReporte { get; set; } = null!;
        public string ImprimirEnmiles { get; set; } = null!;
        public string UnidadesEquivalen { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string DocsDemoneda { get; set; } = null!;
        public string TipoPeriodo { get; set; } = null!;
        public string CompPronostico { get; set; } = null!;
        public string? Pronostico { get; set; }
        public short NumeroPeriodos { get; set; }
        public short AgrupacionPeriodo { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? ClienteIni { get; set; }
        public string? ClienteFin { get; set; }
        public string? CatclienteIni { get; set; }
        public string? CatclienteFin { get; set; }
        public string? VendedorIni { get; set; }
        public string? VendedorFin { get; set; }
        public string? CobradorIni { get; set; }
        public string? CobradorFin { get; set; }
        public string? CuentasIni { get; set; }
        public string? CuentasFin { get; set; }
        public string? PaisIni { get; set; }
        public string? PaisFin { get; set; }
        public string? ZonaIni { get; set; }
        public string? ZonaFin { get; set; }
        public string? RutaIni { get; set; }
        public string? RutaFin { get; set; }
        public string? ArticuloIni { get; set; }
        public string? ArticuloFin { get; set; }
        public string? BodegaIni { get; set; }
        public string? BodegaFin { get; set; }
        public string? Clasificacion1Ini { get; set; }
        public string? Clasificacion1Fin { get; set; }
        public string? Clasificacion2Ini { get; set; }
        public string? Clasificacion2Fin { get; set; }
        public string? Clasificacion3Ini { get; set; }
        public string? Clasificacion3Fin { get; set; }
        public string? Clasificacion4Ini { get; set; }
        public string? Clasificacion4Fin { get; set; }
        public string? Clasificacion5Ini { get; set; }
        public string? Clasificacion5Fin { get; set; }
        public string? Clasificacion6Ini { get; set; }
        public string? Clasificacion6Fin { get; set; }
        public string? TipoDocumento { get; set; }
        public string? CondpagoIni { get; set; }
        public string? CondpagoFin { get; set; }
        public string? NivpreciosIni { get; set; }
        public string? NivpreciosFin { get; set; }
        public string? ClienteOrigenIni { get; set; }
        public string? ClienteOrigenFin { get; set; }
        public string? ClienteCorpIni { get; set; }
        public string? ClienteCorpFin { get; set; }
        public string UnidadesDetalle { get; set; } = null!;
        public string CantidadesEnmiles { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificaci { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public string? UsuarioGeneracion { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public string? Notas { get; set; }
        public string? Titulo1 { get; set; }
        public string? Titulo2 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioGeneracionNavigation { get; set; }
        public virtual Usuario2 UsuarioModificaciNavigation { get; set; } = null!;
        public virtual ICollection<FormatoColumna2> FormatoColumna2s { get; set; }
        public virtual ICollection<FormatoOrden2> FormatoOrden2s { get; set; }
        public virtual ICollection<FormatoUsuario2> FormatoUsuario2s { get; set; }
    }
}
