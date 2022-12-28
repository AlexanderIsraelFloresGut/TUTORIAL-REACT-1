using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EncTablaUdf2
    {
        public EncTablaUdf2()
        {
            TablaUdf2s = new HashSet<TablaUdf2>();
        }

        public string Tabla { get; set; } = null!;
        public string? Notas { get; set; }
        public string? Layout { get; set; }
        public string Tipo { get; set; } = null!;
        public string Etiqueta { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TablaUdf2> TablaUdf2s { get; set; }
    }
}
