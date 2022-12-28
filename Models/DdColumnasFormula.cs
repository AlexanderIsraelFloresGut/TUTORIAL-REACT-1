using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdColumnasFormula
    {
        public string ColumnaCondicion { get; set; } = null!;
        public string Variable { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string PropietarioTabla { get; set; } = null!;
        public Guid IdCase { get; set; }
        public string? ValorNulo { get; set; }
        public int? ValorCero { get; set; }
        public int? Entidad { get; set; }
        public string ValorDefault { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdColumnaCase IdCaseNavigation { get; set; } = null!;
    }
}
