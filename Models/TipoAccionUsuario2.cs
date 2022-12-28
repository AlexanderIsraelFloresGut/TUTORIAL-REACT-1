using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccionUsuario2
    {
        public string TipoAccion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Privilegio { get; set; } = null!;
        public string Crear { get; set; } = null!;
        public string Aprobar { get; set; } = null!;
        public string Desaprobar { get; set; } = null!;
        public string Aplicar { get; set; } = null!;
        public string Desaplicar { get; set; } = null!;
        public string Anular { get; set; } = null!;
        public string Total { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoAccion2 TipoAccionNavigation { get; set; } = null!;
    }
}
