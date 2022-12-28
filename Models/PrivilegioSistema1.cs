using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PrivilegioSistema1
    {
        public PrivilegioSistema1()
        {
            CuboPrivilegio1s = new HashSet<CuboPrivilegio1>();
        }

        public int Privilegio { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Sistema { get; set; } = null!;
        public int? PrivilegioPadre { get; set; }
        public int Posicion { get; set; }
        public string Instalada { get; set; } = null!;
        public string PrivilegioErp { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Url { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Sistema1 SistemaNavigation { get; set; } = null!;
        public virtual ICollection<CuboPrivilegio1> CuboPrivilegio1s { get; set; }
    }
}
