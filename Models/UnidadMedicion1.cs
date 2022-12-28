using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UnidadMedicion1
    {
        public UnidadMedicion1()
        {
            Equipo1s = new HashSet<Equipo1>();
            EspecEquipo1s = new HashSet<EspecEquipo1>();
            FactProcMedic1s = new HashSet<FactProcMedic1>();
        }

        public string UnidadMedicion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<EspecEquipo1> EspecEquipo1s { get; set; }
        public virtual ICollection<FactProcMedic1> FactProcMedic1s { get; set; }
    }
}
