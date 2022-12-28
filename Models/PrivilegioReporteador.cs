using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PrivilegioReporteador
    {
        public int Consecutivo { get; set; }
        public int Accion { get; set; }
        public string Usuario { get; set; } = null!;
        public string? Conjunto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AccionReporteador AccionNavigation { get; set; } = null!;
        public virtual UsuarioLicenciaRp UsuarioNavigation { get; set; } = null!;
    }
}
