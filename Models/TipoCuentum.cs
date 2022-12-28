using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCuentum
    {
        public TipoCuentum()
        {
            CuentaBancaria = new HashSet<CuentaBancarium>();
            Empleados = new HashSet<Empleado>();
            ProveedorEntidads = new HashSet<ProveedorEntidad>();
        }

        public string TipoCuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<ProveedorEntidad> ProveedorEntidads { get; set; }
    }
}
