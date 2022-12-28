using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VUsuario1
    {
        public string Usuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string ReqCambioClave { get; set; } = null!;
        public short FrecuenciaClave { get; set; }
        public DateTime FechaUltClave { get; set; }
        public short MaxIntentosConex { get; set; }
        public string? Clave { get; set; }
        public string? CorreoElectronico { get; set; }
        public string TipoAcceso { get; set; } = null!;
        public string? Celular { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoPersonalizado { get; set; }
    }
}
