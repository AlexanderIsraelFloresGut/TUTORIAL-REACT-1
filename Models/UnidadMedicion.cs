using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UnidadMedicion
    {
        public UnidadMedicion()
        {
            Equipos = new HashSet<Equipo>();
            EspecEquipos = new HashSet<EspecEquipo>();
            FactProcMedics = new HashSet<FactProcMedic>();
        }

        public string UnidadMedicion1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<EspecEquipo> EspecEquipos { get; set; }
        public virtual ICollection<FactProcMedic> FactProcMedics { get; set; }
    }
}
