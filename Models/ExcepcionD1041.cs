using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExcepcionD1041
    {
        public string ClienteExcepcion { get; set; } = null!;
        public string ArticuloExcepcion { get; set; } = null!;
        public string TipoTarifa { get; set; } = null!;
        public string Actividad { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ItemsHaciendum1 ActividadNavigation { get; set; } = null!;
        public virtual Articulo1 ArticuloExcepcionNavigation { get; set; } = null!;
        public virtual Cliente1 ClienteExcepcionNavigation { get; set; } = null!;
    }
}
