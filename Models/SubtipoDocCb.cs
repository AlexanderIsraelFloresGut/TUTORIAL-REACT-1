using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCb
    {
        public SubtipoDocCb()
        {
            Cheques = new HashSet<Cheque>();
            MovBancos = new HashSet<MovBanco>();
            SubtipoDocCcs = new HashSet<SubtipoDocCc>();
            SubtipoDocCps = new HashSet<SubtipoDocCp>();
        }

        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? CuentaContable { get; set; }
        public string? CentroCosto { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string? TipoServicio { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? RubroCf { get; set; }
        public string? RubroPadre { get; set; }
        public string? FlujoCaja { get; set; }
        public string? NaturalezaCf { get; set; }

        public virtual CentroCuentum? C { get; set; }
        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<SubtipoDocCc> SubtipoDocCcs { get; set; }
        public virtual ICollection<SubtipoDocCp> SubtipoDocCps { get; set; }
    }
}
