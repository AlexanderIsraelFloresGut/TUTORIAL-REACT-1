using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Paquete2
    {
        public Paquete2()
        {
            AsientoDeDiario2s = new HashSet<AsientoDeDiario2>();
            AsientoDistribuid2s = new HashSet<AsientoDistribuid2>();
            AsientoMarcado2s = new HashSet<AsientoMarcado2>();
            AsientoRecurrente2s = new HashSet<AsientoRecurrente2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            MovBanco2s = new HashSet<MovBanco2>();
            SubtipoDocCb2s = new HashSet<SubtipoDocCb2>();
            SubtipoDocCc2s = new HashSet<SubtipoDocCc2>();
            SubtipoDocCp2s = new HashSet<SubtipoDocCp2>();
            UsuarioPaquete2s = new HashSet<UsuarioPaquete2>();
        }

        public string Paquete { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string UsuarioCreador { get; set; } = null!;
        public string UltimoUsuario { get; set; } = null!;
        public DateTime FechaUltAcceso { get; set; }
        public string UltimoAsiento { get; set; } = null!;
        public string DobleAsiento { get; set; } = null!;
        public string Marcado { get; set; } = null!;
        public string UsaDobleAsiento { get; set; } = null!;
        public string? UltimoAsientoCorp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreadorNavigation { get; set; } = null!;
        public virtual ICollection<AsientoDeDiario2> AsientoDeDiario2s { get; set; }
        public virtual ICollection<AsientoDistribuid2> AsientoDistribuid2s { get; set; }
        public virtual ICollection<AsientoMarcado2> AsientoMarcado2s { get; set; }
        public virtual ICollection<AsientoRecurrente2> AsientoRecurrente2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<SubtipoDocCb2> SubtipoDocCb2s { get; set; }
        public virtual ICollection<SubtipoDocCc2> SubtipoDocCc2s { get; set; }
        public virtual ICollection<SubtipoDocCp2> SubtipoDocCp2s { get; set; }
        public virtual ICollection<UsuarioPaquete2> UsuarioPaquete2s { get; set; }
    }
}
