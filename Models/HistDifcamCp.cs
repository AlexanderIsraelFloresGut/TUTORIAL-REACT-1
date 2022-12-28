using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistDifcamCp
    {
        public string UsuarioAuditoria { get; set; } = null!;
        public DateTime FechaAuditoria { get; set; }
        public DateTime FechaProc { get; set; }
        public string Documento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public decimal TipoCambioProc { get; set; }
        public string? AsientoProc { get; set; }
        public decimal DifCamLocal { get; set; }
        public decimal DifCamDolar { get; set; }
        public decimal TcambLocDocAnt { get; set; }
        public decimal TcambDolDocAnt { get; set; }
        public decimal TcambLocDocAct { get; set; }
        public decimal TcambDolDocAct { get; set; }
        public string? CuentaContable { get; set; }
        public string? CentroCosto { get; set; }
        public string Estado { get; set; } = null!;
        public string? NotasRev { get; set; }
        public Guid IdHist { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioAuditoriaNavigation { get; set; } = null!;
    }
}
