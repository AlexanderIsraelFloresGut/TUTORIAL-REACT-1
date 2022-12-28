using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoFormula2
    {
        public ConceptoFormula2()
        {
            ConcFormConcepto2s = new HashSet<ConcFormConcepto2>();
            ConcFormRubro2s = new HashSet<ConcFormRubro2>();
        }

        public string Concepto { get; set; } = null!;
        public short Secuencia { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Monto { get; set; }
        public string Formula { get; set; } = null!;
        public short NivelFormula { get; set; }
        public string UsaCantidad { get; set; } = null!;
        public string UsaMonto { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual ICollection<ConcFormConcepto2> ConcFormConcepto2s { get; set; }
        public virtual ICollection<ConcFormRubro2> ConcFormRubro2s { get; set; }
    }
}
