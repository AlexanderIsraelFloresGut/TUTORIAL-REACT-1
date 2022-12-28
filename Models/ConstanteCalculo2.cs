using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConstanteCalculo2
    {
        public ConstanteCalculo2()
        {
            ConstanteCalcValor2s = new HashSet<ConstanteCalcValor2>();
        }

        public string Constante { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ConstanteCalcValor2> ConstanteCalcValor2s { get; set; }
    }
}
