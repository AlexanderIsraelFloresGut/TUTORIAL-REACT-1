using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoCuentum2
    {
        public TipoCuentum2()
        {
            CuentaBancarium2s = new HashSet<CuentaBancarium2>();
            Empleado2s = new HashSet<Empleado2>();
            ProveedorEntidad2s = new HashSet<ProveedorEntidad2>();
        }

        public string TipoCuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CuentaBancarium2> CuentaBancarium2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<ProveedorEntidad2> ProveedorEntidad2s { get; set; }
    }
}
