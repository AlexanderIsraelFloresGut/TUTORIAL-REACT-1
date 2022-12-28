using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Adicionalempleado2
    {
        public string Adicional { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Adicional2 AdicionalNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
    }
}
