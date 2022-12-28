using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Documento1
    {
        public Documento1()
        {
            DocumentosRh1s = new HashSet<DocumentosRh1>();
            EmpleadoDocumento1s = new HashSet<EmpleadoDocumento1>();
            SolicitudRhDoc1s = new HashSet<SolicitudRhDoc1>();
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

        public virtual ICollection<DocumentosRh1> DocumentosRh1s { get; set; }
        public virtual ICollection<EmpleadoDocumento1> EmpleadoDocumento1s { get; set; }
        public virtual ICollection<SolicitudRhDoc1> SolicitudRhDoc1s { get; set; }
    }
}
