using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ResponSeguimiento2
    {
        public ResponSeguimiento2()
        {
            OrdenCompra2s = new HashSet<OrdenCompra2>();
        }

        public string ResponSeguimiento { get; set; } = null!;
        public string? Empleado { get; set; }
        public string Estado { get; set; } = null!;
        public string? Notas { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElect { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
    }
}
