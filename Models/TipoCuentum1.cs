using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCuentum1
    {
        public TipoCuentum1()
        {
            CuentaBancarium1s = new HashSet<CuentaBancarium1>();
            Empleado1s = new HashSet<Empleado1>();
            ProveedorEntidad1s = new HashSet<ProveedorEntidad1>();
        }

        public string TipoCuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaBancarium1> CuentaBancarium1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<ProveedorEntidad1> ProveedorEntidad1s { get; set; }
    }
}
