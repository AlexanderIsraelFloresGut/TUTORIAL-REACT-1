using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class FormatoOrden
    {
        public string Formato { get; set; } = null!;
        public string Orden { get; set; } = null!;
        public short? PosicionOrden { get; set; }
        public string Despliegue { get; set; } = null!;
        public string OrdenCol { get; set; } = null!;
        public string Ordenamiento { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Formato FormatoNavigation { get; set; } = null!;
    }
}
