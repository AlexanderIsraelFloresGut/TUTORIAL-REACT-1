using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MovProcesado2
    {
        public string CuentaBanco { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public decimal Numero { get; set; }
        public string ArchivoTxt { get; set; } = null!;
        public DateTime FechaGenerado { get; set; }
        public string UsuarioProcesa { get; set; } = null!;
        public DateTime FechaProcesa { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaBancarium2 CuentaBancoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioProcesaNavigation { get; set; } = null!;
    }
}
