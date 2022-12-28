using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SentenciasSql
    {
        public SentenciasSql()
        {
            AplicaEsquemas = new HashSet<AplicaEsquema>();
        }

        public int Idsql { get; set; }
        public string NombreSql { get; set; } = null!;
        public string DescripcionSql { get; set; } = null!;
        public string ContenidoSql { get; set; } = null!;
        public string AplicarRecurrente { get; set; } = null!;
        public string AplicarNuevascias { get; set; } = null!;
        public string TipoEsquema { get; set; } = null!;
        public int Version { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioModificacionNavigation { get; set; } = null!;
        public virtual ICollection<AplicaEsquema> AplicaEsquemas { get; set; }
    }
}
