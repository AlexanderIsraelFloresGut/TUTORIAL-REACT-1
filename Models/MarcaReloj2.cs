using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MarcaReloj2
    {
        public string Empleado { get; set; } = null!;
        public DateTime FchHoraEntrada { get; set; }
        public string Usuario { get; set; } = null!;
        public string Horario { get; set; } = null!;
        public DateTime? FchHoraSalida { get; set; }
        public string Cargado { get; set; } = null!;
        public string Consistente { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual Horario2 HorarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
