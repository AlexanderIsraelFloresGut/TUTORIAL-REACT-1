using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConstanteCalculo
    {
        public ConstanteCalculo()
        {
            ConstanteCalcValors = new HashSet<ConstanteCalcValor>();
        }

        public string Constante { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ConstanteCalcValor> ConstanteCalcValors { get; set; }
    }
}
