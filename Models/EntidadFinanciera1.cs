using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EntidadFinanciera1
    {
        public EntidadFinanciera1()
        {
            CreditoEmpleado1s = new HashSet<CreditoEmpleado1>();
            CuentaBancarium1s = new HashSet<CuentaBancarium1>();
            DetTransCb1s = new HashSet<DetTransCb1>();
            Empleado1s = new HashSet<Empleado1>();
            FacturaCancela1s = new HashSet<FacturaCancela1>();
            FormatoTransfer1s = new HashSet<FormatoTransfer1>();
            ProveedorEntidad1s = new HashSet<ProveedorEntidad1>();
        }

        public string EntidadFinanciera { get; set; } = null!;
        public string? Nit { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? CodElectronico { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Nit1? NitNavigation { get; set; }
        public virtual ICollection<CreditoEmpleado1> CreditoEmpleado1s { get; set; }
        public virtual ICollection<CuentaBancarium1> CuentaBancarium1s { get; set; }
        public virtual ICollection<DetTransCb1> DetTransCb1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<FacturaCancela1> FacturaCancela1s { get; set; }
        public virtual ICollection<FormatoTransfer1> FormatoTransfer1s { get; set; }
        public virtual ICollection<ProveedorEntidad1> ProveedorEntidad1s { get; set; }
    }
}
