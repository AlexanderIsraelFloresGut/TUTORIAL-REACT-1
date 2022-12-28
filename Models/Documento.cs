using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Documento
    {
        public Documento()
        {
            DocumentosRhs = new HashSet<DocumentosRh>();
            EmpleadoDocumentos = new HashSet<EmpleadoDocumento>();
            SolicitudRhDocs = new HashSet<SolicitudRhDoc>();
        }

        public int Documento1 { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Contenido { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DocumentosRh> DocumentosRhs { get; set; }
        public virtual ICollection<EmpleadoDocumento> EmpleadoDocumentos { get; set; }
        public virtual ICollection<SolicitudRhDoc> SolicitudRhDocs { get; set; }
    }
}
