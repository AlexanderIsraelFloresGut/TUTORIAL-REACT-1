using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SeccionCuentum
    {
        public SeccionCuentum()
        {
            CuentaContables = new HashSet<CuentaContable>();
        }

        public string SeccionCuenta { get; set; } = null!;
        public string TipoSeccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Acumulado { get; set; }
        public short Secuencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaContable> CuentaContables { get; set; }
    }
}
