using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VistaBi
    {
        public VistaBi()
        {
            DefinicionPivoteBis = new HashSet<DefinicionPivoteBi>();
        }

        public string Vista { get; set; } = null!;
        public string Modulo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoConexion { get; set; } = null!;
        public string? Conexion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DefinicionPivoteBi> DefinicionPivoteBis { get; set; }
    }
}
