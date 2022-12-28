using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuboPrivilegio
    {
        public CuboPrivilegio()
        {
            DefinicionPivoteBis = new HashSet<DefinicionPivoteBi>();
            Meta = new HashSet<Metum>();
            VistasPivotes = new HashSet<VistasPivote>();
        }

        public string Cubo { get; set; } = null!;
        public string UsaMetas { get; set; } = null!;
        public int? Privilegio { get; set; }
        public string? Descripcion { get; set; }
        public string? Modulo { get; set; }
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PrivilegioSistema? PrivilegioNavigation { get; set; }
        public virtual ICollection<DefinicionPivoteBi> DefinicionPivoteBis { get; set; }
        public virtual ICollection<Metum> Meta { get; set; }
        public virtual ICollection<VistasPivote> VistasPivotes { get; set; }
    }
}
