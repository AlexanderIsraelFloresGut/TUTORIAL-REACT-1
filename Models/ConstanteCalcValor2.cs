using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConstanteCalcValor2
    {
        public string Variable { get; set; } = null!;
        public string Constante { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Valor { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ConstanteCalculo2 ConstanteNavigation { get; set; } = null!;
    }
}
