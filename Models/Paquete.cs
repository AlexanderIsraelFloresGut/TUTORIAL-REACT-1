using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Paquete
    {
        public Paquete()
        {
            AsientoDeDiarios = new HashSet<AsientoDeDiario>();
            AsientoDistribuids = new HashSet<AsientoDistribuid>();
            AsientoMarcados = new HashSet<AsientoMarcado>();
            AsientoRecurrentes = new HashSet<AsientoRecurrente>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            MovBancos = new HashSet<MovBanco>();
            SubtipoDocCbs = new HashSet<SubtipoDocCb>();
            SubtipoDocCcs = new HashSet<SubtipoDocCc>();
            SubtipoDocCps = new HashSet<SubtipoDocCp>();
            UsuarioPaquetes = new HashSet<UsuarioPaquete>();
        }

        public string Paquete1 { get; set; } = null!;
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
        public virtual ICollection<AsientoDeDiario> AsientoDeDiarios { get; set; }
        public virtual ICollection<AsientoDistribuid> AsientoDistribuids { get; set; }
        public virtual ICollection<AsientoMarcado> AsientoMarcados { get; set; }
        public virtual ICollection<AsientoRecurrente> AsientoRecurrentes { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<SubtipoDocCb> SubtipoDocCbs { get; set; }
        public virtual ICollection<SubtipoDocCc> SubtipoDocCcs { get; set; }
        public virtual ICollection<SubtipoDocCp> SubtipoDocCps { get; set; }
        public virtual ICollection<UsuarioPaquete> UsuarioPaquetes { get; set; }
    }
}
