using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsParametrosPr1
    {
        public int IdParametro { get; set; }
        public string BodegaMp { get; set; } = null!;
        public string BodegaPt { get; set; } = null!;
        public string? ClasificacionPr { get; set; }
        public string ClasificacionMateriaPrima { get; set; } = null!;
        public string ClasificacionMaterialesDirectos { get; set; } = null!;
        public string BodegaMaterialesDirectos { get; set; } = null!;
        public string? Paquete { get; set; }
        public string? CuentaCif { get; set; }
        public string? CentroBcf { get; set; }
        public string? CuentaCifDebito { get; set; }
        public string? CentroBcfDebito { get; set; }
        public string? ConsumoEspecifico { get; set; }
        public string? BodegaExportacion { get; set; }
        public string? BodegaInventario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
