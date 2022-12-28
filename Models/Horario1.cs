using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Horario1
    {
        public Horario1()
        {
            Empleado1s = new HashSet<Empleado1>();
            HorarioConcepto1s = new HashSet<HorarioConcepto1>();
            MarcaReloj1s = new HashSet<MarcaReloj1>();
        }

        public string Horario { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public short ToleraEntrada { get; set; }
        public short ToleraSalida { get; set; }
        public short RedondeoEntrad { get; set; }
        public short RedondeoSalida { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? HorasIncapacidad { get; set; }

        public virtual FactorAjuHora1 FactorAjuHora1 { get; set; } = null!;
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<HorarioConcepto1> HorarioConcepto1s { get; set; }
        public virtual ICollection<MarcaReloj1> MarcaReloj1s { get; set; }
    }
}
