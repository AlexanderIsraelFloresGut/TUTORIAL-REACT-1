using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BitacoraSolicitude
    {
        public int Bitacora { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public string? Proveedor { get; set; }
        public string? SolicitudCompra { get; set; }
        public string Generica { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public string? Acopiador { get; set; }
        public string? Moneda { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
