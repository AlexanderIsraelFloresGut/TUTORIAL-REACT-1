using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CajaBanco1
    {
        public string CajaChica { get; set; } = null!;
        public string CuentaBanco { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CajaChica1 CajaChicaNavigation { get; set; } = null!;
        public virtual CuentaBancarium1 CuentaBancoNavigation { get; set; } = null!;
    }
}
