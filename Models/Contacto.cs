using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Contacto
    {
        public string Gln { get; set; } = null!;
        public string Cedulajuridica { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? EmailEdi { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
