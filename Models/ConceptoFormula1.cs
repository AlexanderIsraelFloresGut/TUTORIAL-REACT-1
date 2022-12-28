using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoFormula1
    {
        public ConceptoFormula1()
        {
            ConcFormConcepto1s = new HashSet<ConcFormConcepto1>();
            ConcFormRubro1s = new HashSet<ConcFormRubro1>();
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

        public virtual Concepto1 ConceptoNavigation { get; set; } = null!;
        public virtual ICollection<ConcFormConcepto1> ConcFormConcepto1s { get; set; }
        public virtual ICollection<ConcFormRubro1> ConcFormRubro1s { get; set; }
    }
}
