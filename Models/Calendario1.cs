using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Calendario1
    {
        public Calendario1()
        {
            CalendarioAno1s = new HashSet<CalendarioAno1>();
            CalendarioDet1s = new HashSet<CalendarioDet1>();
            Equipo1s = new HashSet<Equipo1>();
        }

        public string Calendario { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short MinutosLunes { get; set; }
        public short MinutosMartes { get; set; }
        public short MinutosMiercoles { get; set; }
        public short MinutosJueves { get; set; }
        public short MinutosViernes { get; set; }
        public short MinutosSabado { get; set; }
        public short MinutosDomingo { get; set; }
        public string UsuarioUltMod { get; set; } = null!;
        public DateTime FechaHoraUltMod { get; set; }
        public string? Notas { get; set; }
        public DateTime InicioLunes { get; set; }
        public DateTime InicioMartes { get; set; }
        public DateTime InicioMiercoles { get; set; }
        public DateTime InicioJueves { get; set; }
        public DateTime InicioViernes { get; set; }
        public DateTime InicioSabado { get; set; }
        public DateTime InicioDomingo { get; set; }
        public DateTime FinalLunes { get; set; }
        public DateTime FinalMartes { get; set; }
        public DateTime FinalMiercoles { get; set; }
        public DateTime FinalJueves { get; set; }
        public DateTime FinalViernes { get; set; }
        public DateTime FinalSabado { get; set; }
        public DateTime FinalDomingo { get; set; }
        public string HabilLunes { get; set; } = null!;
        public string HabilMartes { get; set; } = null!;
        public string HabilMiercoles { get; set; } = null!;
        public string HabilJueves { get; set; } = null!;
        public string HabilViernes { get; set; } = null!;
        public string HabilSabado { get; set; } = null!;
        public string HabilDomingo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioUltModNavigation { get; set; } = null!;
        public virtual ICollection<CalendarioAno1> CalendarioAno1s { get; set; }
        public virtual ICollection<CalendarioDet1> CalendarioDet1s { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
    }
}
