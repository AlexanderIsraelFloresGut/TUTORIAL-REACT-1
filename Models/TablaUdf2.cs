using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TablaUdf2
    {
        public string Tabla { get; set; } = null!;
        public string Udf { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int Orden { get; set; }
        public string PermiteNulos { get; set; } = null!;
        public string? ValorDefault { get; set; }
        public string? Sql { get; set; }
        public string TipoFuente { get; set; } = null!;
        public string? Udt { get; set; }
        public short? Largo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EncTablaUdf2 TablaNavigation { get; set; } = null!;
    }
}
