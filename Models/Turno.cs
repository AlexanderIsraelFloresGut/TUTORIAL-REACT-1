using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Turno
    {
        public Turno()
        {
            OpOperDets = new HashSet<OpOperDet>();
            OrdenTrabajoTurnoEntregaNavigations = new HashSet<OrdenTrabajo>();
            OrdenTrabajoTurnoRecepcionNavigations = new HashSet<OrdenTrabajo>();
            OrdenTrabajoTurnoSolicitudNavigations = new HashSet<OrdenTrabajo>();
        }

        public short Turno1 { get; set; }
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

        public virtual ICollection<OpOperDet> OpOperDets { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoTurnoEntregaNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoTurnoRecepcionNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajoTurnoSolicitudNavigations { get; set; }
    }
}
