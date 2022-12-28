using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AsientoMayorizado2
    {
        public AsientoMayorizado2()
        {
            Mayor2s = new HashSet<Mayor2>();
        }

        public string Asiento { get; set; } = null!;
        public int MayorAuditoria { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Contabilidad { get; set; } = null!;
        public string Origen { get; set; } = null!;
        public string ClaseAsiento { get; set; } = null!;
        public string UltimoUsuario { get; set; } = null!;
        public DateTime FechaUltModif { get; set; }
        public decimal MontoTotalLocal { get; set; }
        public decimal MontoTotalDolar { get; set; }
        public string? Notas { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string Exportado { get; set; } = null!;
        public string TipoIngresoMayor { get; set; } = null!;
        public string? Dependencia { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual MayorAuditorium2 MayorAuditoriaNavigation { get; set; } = null!;
        public virtual TipoAsiento2 TipoAsientoNavigation { get; set; } = null!;
        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual ICollection<Mayor2> Mayor2s { get; set; }
    }
}
