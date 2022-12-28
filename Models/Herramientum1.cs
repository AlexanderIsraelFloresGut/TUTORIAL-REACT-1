using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Herramientum1
    {
        public Herramientum1()
        {
            ProceHerramientum1s = new HashSet<ProceHerramientum1>();
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

        public virtual ICollection<ProceHerramientum1> ProceHerramientum1s { get; set; }
    }
}
