using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EncTablaUdf1
    {
        public EncTablaUdf1()
        {
            TablaUdf1s = new HashSet<TablaUdf1>();
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

        public virtual ICollection<TablaUdf1> TablaUdf1s { get; set; }
    }
}
