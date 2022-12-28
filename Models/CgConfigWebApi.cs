using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CgConfigWebApi
    {
        public string Compania { get; set; } = null!;
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? DireccionQueryx { get; set; }
        public string AsocCentroCuenta { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
