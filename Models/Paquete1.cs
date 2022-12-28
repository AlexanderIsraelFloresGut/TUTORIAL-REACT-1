using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Paquete1
    {
        public Paquete1()
        {
            AsientoDeDiario1s = new HashSet<AsientoDeDiario1>();
            AsientoDistribuid1s = new HashSet<AsientoDistribuid1>();
            AsientoMarcado1s = new HashSet<AsientoMarcado1>();
            AsientoRecurrente1s = new HashSet<AsientoRecurrente1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            MovBanco1s = new HashSet<MovBanco1>();
            SubtipoDocCb1s = new HashSet<SubtipoDocCb1>();
            SubtipoDocCc1s = new HashSet<SubtipoDocCc1>();
            SubtipoDocCp1s = new HashSet<SubtipoDocCp1>();
            UsuarioPaquete1s = new HashSet<UsuarioPaquete1>();
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
        public virtual ICollection<AsientoDeDiario1> AsientoDeDiario1s { get; set; }
        public virtual ICollection<AsientoDistribuid1> AsientoDistribuid1s { get; set; }
        public virtual ICollection<AsientoMarcado1> AsientoMarcado1s { get; set; }
        public virtual ICollection<AsientoRecurrente1> AsientoRecurrente1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<SubtipoDocCb1> SubtipoDocCb1s { get; set; }
        public virtual ICollection<SubtipoDocCc1> SubtipoDocCc1s { get; set; }
        public virtual ICollection<SubtipoDocCp1> SubtipoDocCp1s { get; set; }
        public virtual ICollection<UsuarioPaquete1> UsuarioPaquete1s { get; set; }
    }
}
