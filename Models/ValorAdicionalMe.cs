using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ValorAdicionalMe
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? BaseLocal { get; set; }
        public decimal? BaseDolar { get; set; }
        public string? ConceptoMe { get; set; }
        public decimal? MontoIva { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public string IvaMayorValorCosto { get; set; } = null!;
        public string Asumido { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoImpuesto { get; set; }

        public virtual TipoImpuesto? TipoImpuestoNavigation { get; set; }
    }
}
