using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdCargaConstr
    {
        public string NombreTabla { get; set; } = null!;
        public string NombreColum { get; set; } = null!;
        public string ValorConstr { get; set; } = null!;
        public string DefinicionConstr { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
