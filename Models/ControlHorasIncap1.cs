using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ControlHorasIncap1
    {
        public string Empleado { get; set; } = null!;
        public int Consecutivo { get; set; }
        public string Nomina { get; set; } = null!;
        public short NumeroNomina { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal HorasVencidas { get; set; }
        public decimal HorasConsumidas { get; set; }
        public decimal HorasCausadas { get; set; }
        public decimal Saldo { get; set; }
        public string Aceptado { get; set; } = null!;
        public int? Accion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
    }
}
