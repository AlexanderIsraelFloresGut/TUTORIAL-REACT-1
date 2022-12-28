using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubtipoDocCb2
    {
        public SubtipoDocCb2()
        {
            Cheque2s = new HashSet<Cheque2>();
            MovBanco2s = new HashSet<MovBanco2>();
            SubtipoDocCc2s = new HashSet<SubtipoDocCc2>();
            SubtipoDocCp2s = new HashSet<SubtipoDocCp2>();
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

        public virtual CentroCuentum2? C { get; set; }
        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
        public virtual ICollection<Cheque2> Cheque2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<SubtipoDocCc2> SubtipoDocCc2s { get; set; }
        public virtual ICollection<SubtipoDocCp2> SubtipoDocCp2s { get; set; }
    }
}
