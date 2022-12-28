using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NominaBanco1
    {
        public string Nomina { get; set; } = null!;
        public string CuentaBanco { get; set; } = null!;
        public string? CtaDefault { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaBancarium1 CuentaBancoNavigation { get; set; } = null!;
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
    }
}
