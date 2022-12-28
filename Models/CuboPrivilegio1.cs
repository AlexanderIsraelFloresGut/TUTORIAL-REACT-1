using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuboPrivilegio1
    {
        public CuboPrivilegio1()
        {
            DefinicionPivoteBi1s = new HashSet<DefinicionPivoteBi1>();
            Metum1s = new HashSet<Metum1>();
            VistasPivote1s = new HashSet<VistasPivote1>();
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

        public virtual PrivilegioSistema1? PrivilegioNavigation { get; set; }
        public virtual ICollection<DefinicionPivoteBi1> DefinicionPivoteBi1s { get; set; }
        public virtual ICollection<Metum1> Metum1s { get; set; }
        public virtual ICollection<VistasPivote1> VistasPivote1s { get; set; }
    }
}
