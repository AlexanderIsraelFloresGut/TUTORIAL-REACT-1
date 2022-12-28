using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoDistLinea2
    {
        public string TipoLinea { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string AsientoDistribuid { get; set; } = null!;
        public string? Nit { get; set; }
        public string CentroCosto { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string Funcion { get; set; } = null!;
        public string? DetalleFuncion { get; set; }
        public short? IndiceFuncion { get; set; }
        public string? Comentario { get; set; }
        public decimal? MontoBase { get; set; }
        public string MonedaBase { get; set; } = null!;
        public string UsaTcambioExt { get; set; } = null!;
        public string? Proyecto { get; set; }
        public string? Fase { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AsientoDistribuid2 AsientoDistribu { get; set; } = null!;
        public virtual CentroCuentum2 C { get; set; } = null!;
        public virtual Nit2? NitNavigation { get; set; }
    }
}
