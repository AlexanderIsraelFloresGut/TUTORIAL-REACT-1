using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Horario2
    {
        public Horario2()
        {
            Empleado2s = new HashSet<Empleado2>();
            HorarioConcepto2s = new HashSet<HorarioConcepto2>();
            MarcaReloj2s = new HashSet<MarcaReloj2>();
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

        public virtual FactorAjuHora2 FactorAjuHora2 { get; set; } = null!;
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<HorarioConcepto2> HorarioConcepto2s { get; set; }
        public virtual ICollection<MarcaReloj2> MarcaReloj2s { get; set; }
    }
}
