using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoHistReval1
    {
        public int HistRevaluacion { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string Mejora { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Metodo { get; set; } = null!;
        public decimal RevalValor { get; set; }
        public decimal RevalValorC { get; set; }
        public decimal RevalDeprAcumF { get; set; }
        public decimal RevalDeprAcumC { get; set; }
        public decimal TipoCambio { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string? AsientoFiscal { get; set; }
        public string? AsientoComp { get; set; }
        public string? Comentario { get; set; }
        public string MetodoC { get; set; } = null!;
        public int? ConsecDeprF { get; set; }
        public int? ConsecDeprC { get; set; }
        public string AjusteInflaF { get; set; } = null!;
        public string AjusteInflaC { get; set; } = null!;
        public decimal AjuInflacDeprecF { get; set; }
        public decimal AjuInflacDeprecC { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Desmantelamiento { get; set; }

        public virtual ActivoMejora1 ActivoMejora1 { get; set; } = null!;
        public virtual HistDepreciacion1? ConsecDeprCNavigation { get; set; }
        public virtual HistDepreciacion1? ConsecDeprFNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
