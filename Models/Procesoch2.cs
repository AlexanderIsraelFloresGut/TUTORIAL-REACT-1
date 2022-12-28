using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Procesoch2
    {
        public int Consecutivo { get; set; }
        public string CajaChica { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Documento { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; } = null!;
        public string? Asiento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CajaChica2 CajaChicaNavigation { get; set; } = null!;
    }
}
