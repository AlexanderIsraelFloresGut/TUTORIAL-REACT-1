using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Documento2
    {
        public Documento2()
        {
            DocumentosRh2s = new HashSet<DocumentosRh2>();
            EmpleadoDocumento2s = new HashSet<EmpleadoDocumento2>();
            SolicitudRhDoc2s = new HashSet<SolicitudRhDoc2>();
        }

        public int Documento { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Contenido { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosRh2> DocumentosRh2s { get; set; }
        public virtual ICollection<EmpleadoDocumento2> EmpleadoDocumento2s { get; set; }
        public virtual ICollection<SolicitudRhDoc2> SolicitudRhDoc2s { get; set; }
    }
}
