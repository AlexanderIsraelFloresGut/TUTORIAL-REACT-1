using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AplicaEsquema
    {
        public int IdaplicaEsquema { get; set; }
        public int Idsql { get; set; }
        public int Version { get; set; }
        public string UsuarioAplicacion { get; set; } = null!;
        public DateTime FechaAplicacion { get; set; }
        public string ResultadoAplicacion { get; set; } = null!;
        public string NombreEsquema { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SentenciasSql IdsqlNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioAplicacionNavigation { get; set; } = null!;
    }
}
