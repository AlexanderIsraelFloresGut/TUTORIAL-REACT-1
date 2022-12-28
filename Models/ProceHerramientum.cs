using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProceHerramientum
    {
        public string Articulo { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string Herramienta { get; set; } = null!;
        public short CantidadUtilizada { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstrucProceso EstrucProceso { get; set; } = null!;
        public virtual Herramientum HerramientaNavigation { get; set; } = null!;
    }
}
