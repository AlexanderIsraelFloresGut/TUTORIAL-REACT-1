using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesgloseCierreAudit1
    {
        public string OrdenProduccion { get; set; } = null!;
        public int? AuditTransInv { get; set; }
        public string? AsientoCierre { get; set; }
        public string? Articulo { get; set; }
        public decimal AjusteAplicadoL { get; set; }
        public decimal AjusteNoAplicadoL { get; set; }
        public decimal MontoDesperdicioL { get; set; }
        public decimal AjusteMoL { get; set; }
        public decimal AjusteGifL { get; set; }
        public decimal AjusteMatL { get; set; }
        public decimal AjusteAplicadoD { get; set; }
        public decimal AjusteNoAplicadoD { get; set; }
        public decimal MontoDesperdicioD { get; set; }
        public decimal AjusteMoD { get; set; }
        public decimal AjusteGifD { get; set; }
        public decimal AjusteMatD { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
