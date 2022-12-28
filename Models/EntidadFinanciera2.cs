using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EntidadFinanciera2
    {
        public EntidadFinanciera2()
        {
            CreditoEmpleado2s = new HashSet<CreditoEmpleado2>();
            CuentaBancarium2s = new HashSet<CuentaBancarium2>();
            DetTransCb2s = new HashSet<DetTransCb2>();
            Empleado2s = new HashSet<Empleado2>();
            FacturaCancela2s = new HashSet<FacturaCancela2>();
            FormatoTransfer2s = new HashSet<FormatoTransfer2>();
            ProveedorEntidad2s = new HashSet<ProveedorEntidad2>();
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

        public virtual Nit2? NitNavigation { get; set; }
        public virtual ICollection<CreditoEmpleado2> CreditoEmpleado2s { get; set; }
        public virtual ICollection<CuentaBancarium2> CuentaBancarium2s { get; set; }
        public virtual ICollection<DetTransCb2> DetTransCb2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<FacturaCancela2> FacturaCancela2s { get; set; }
        public virtual ICollection<FormatoTransfer2> FormatoTransfer2s { get; set; }
        public virtual ICollection<ProveedorEntidad2> ProveedorEntidad2s { get; set; }
    }
}
