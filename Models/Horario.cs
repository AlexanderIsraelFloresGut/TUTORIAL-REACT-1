using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Horario
    {
        public Horario()
        {
            Empleados = new HashSet<Empleado>();
            HorarioConceptos = new HashSet<HorarioConcepto>();
            MarcaRelojs = new HashSet<MarcaReloj>();
        }

        public string Horario1 { get; set; } = null!;
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

        public virtual FactorAjuHora FactorAjuHora { get; set; } = null!;
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<HorarioConcepto> HorarioConceptos { get; set; }
        public virtual ICollection<MarcaReloj> MarcaRelojs { get; set; }
    }
}
