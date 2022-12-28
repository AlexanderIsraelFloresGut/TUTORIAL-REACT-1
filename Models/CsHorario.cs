using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsHorario
    {
        public CsHorario()
        {
            CsEmpleadoHorarios = new HashSet<CsEmpleadoHorario>();
        }

        public string HorarioId { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public decimal HorasDescanso { get; set; }
        public decimal HorasEfectivas { get; set; }
        public string TipoHorario { get; set; } = null!;

        public virtual ICollection<CsEmpleadoHorario> CsEmpleadoHorarios { get; set; }
    }
}
