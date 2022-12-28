using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProvValoresCertif
    {
        public string Proveedor { get; set; } = null!;
        public DateTime Periodo { get; set; }
        public decimal? PagosAbonos { get; set; }
        public decimal? AportesSalud { get; set; }
        public decimal? AportesPension { get; set; }
        public decimal? AportesAfc { get; set; }
        public decimal? BaseRetUvt { get; set; }
        public decimal? PorcentajeRet { get; set; }
        public decimal? PagosAbonosReal { get; set; }
        public decimal? PorcentajeRetReal { get; set; }
        public decimal? RetenidoAplicado { get; set; }
        public decimal? RetenidoAjustado { get; set; }
        public decimal? DiferenciaRet { get; set; }
        public DateTime? FechaUltAjuste { get; set; }
        public decimal? AportesPensionVol { get; set; }
        public decimal? InteresPrestamo { get; set; }
        public decimal? AportesSaludReal { get; set; }
        public decimal? AportesPenReal { get; set; }
        public decimal? AportesPenVolReal { get; set; }
        public decimal? AportesAfcReal { get; set; }
        public decimal? InteresPrestReal { get; set; }
        public decimal? AportesMinima { get; set; }
        public decimal? AportesAcumUvt { get; set; }
        public string Declarante { get; set; } = null!;
        public decimal? AporteSaludVoluntaria { get; set; }
        public decimal? Dependientes { get; set; }
        public decimal? RentaExenta { get; set; }
        public decimal? AportesMinimaReal { get; set; }
        public string? CuentaContable383 { get; set; }
        public string? CentroCosto383 { get; set; }
        public string? CuentaContable384 { get; set; }
        public string? CentroCosto384 { get; set; }
        public decimal? AporteSaludVoluntarioReal { get; set; }
        public decimal? DependientesReal { get; set; }
        public decimal? RentaExentaReal { get; set; }
        public decimal? AcumRentaExentaUvt { get; set; }
        public string? Es383 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual CentroCuentum? CNavigation { get; set; }
        public virtual Proveedor ProveedorNavigation { get; set; } = null!;
    }
}
