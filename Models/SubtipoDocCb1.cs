using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCb1
    {
        public SubtipoDocCb1()
        {
            Cheque1s = new HashSet<Cheque1>();
            MovBanco1s = new HashSet<MovBanco1>();
            SubtipoDocCc1s = new HashSet<SubtipoDocCc1>();
            SubtipoDocCp1s = new HashSet<SubtipoDocCp1>();
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

        public virtual CentroCuentum1? C { get; set; }
        public virtual Paquete1? PaqueteNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoNavigation { get; set; }
        public virtual ICollection<Cheque1> Cheque1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<SubtipoDocCc1> SubtipoDocCc1s { get; set; }
        public virtual ICollection<SubtipoDocCp1> SubtipoDocCp1s { get; set; }
    }
}
