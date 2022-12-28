using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ContrarecibosCc2
    {
        public string Cliente { get; set; } = null!;
        public string Contrarecibo { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string Congelado { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public DateTime FechaRige { get; set; }
        public string Estado { get; set; } = null!;
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FechaUltMod { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Cliente2 ClienteNavigation { get; set; } = null!;
        public virtual CondicionPago2 CondicionPagoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
    }
}
