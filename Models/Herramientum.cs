using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Herramientum
    {
        public Herramientum()
        {
            ProceHerramienta = new HashSet<ProceHerramientum>();
        }

        public string Herramienta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short Existencia { get; set; }
        public decimal CostoReemplazo { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ProceHerramientum> ProceHerramienta { get; set; }
    }
}
