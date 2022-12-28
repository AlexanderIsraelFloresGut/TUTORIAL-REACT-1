using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EntidadFinanciera
    {
        public EntidadFinanciera()
        {
            CreditoEmpleados = new HashSet<CreditoEmpleado>();
            CuentaBancaria = new HashSet<CuentaBancarium>();
            DetTransCbs = new HashSet<DetTransCb>();
            Empleados = new HashSet<Empleado>();
            FacturaCancelas = new HashSet<FacturaCancela>();
            FormatoTransfers = new HashSet<FormatoTransfer>();
            ProveedorEntidads = new HashSet<ProveedorEntidad>();
        }

        public string EntidadFinanciera1 { get; set; } = null!;
        public string? Nit { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? CodElectronico { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Nit? NitNavigation { get; set; }
        public virtual ICollection<CreditoEmpleado> CreditoEmpleados { get; set; }
        public virtual ICollection<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual ICollection<DetTransCb> DetTransCbs { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<FacturaCancela> FacturaCancelas { get; set; }
        public virtual ICollection<FormatoTransfer> FormatoTransfers { get; set; }
        public virtual ICollection<ProveedorEntidad> ProveedorEntidads { get; set; }
    }
}
