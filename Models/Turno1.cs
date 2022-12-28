using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Turno1
    {
        public Turno1()
        {
            OpOperDet1s = new HashSet<OpOperDet1>();
            OrdenTrabajo1TurnoEntregaNavigations = new HashSet<OrdenTrabajo1>();
            OrdenTrabajo1TurnoRecepcionNavigations = new HashSet<OrdenTrabajo1>();
            OrdenTrabajo1TurnoSolicitudNavigations = new HashSet<OrdenTrabajo1>();
        }

        public short Turno { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public decimal Duracion { get; set; }
        public decimal MinutosNoproduc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OpOperDet1> OpOperDet1s { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1TurnoEntregaNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1TurnoRecepcionNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1TurnoSolicitudNavigations { get; set; }
    }
}
