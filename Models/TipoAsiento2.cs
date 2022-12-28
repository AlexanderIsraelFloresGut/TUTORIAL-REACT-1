using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAsiento2
    {
        public TipoAsiento2()
        {
            AsientoDeDiario2s = new HashSet<AsientoDeDiario2>();
            AsientoDistribuid2s = new HashSet<AsientoDistribuid2>();
            AsientoMayorizado2s = new HashSet<AsientoMayorizado2>();
            AsientoRecurrente2s = new HashSet<AsientoRecurrente2>();
            AsientosCheque2s = new HashSet<AsientosCheque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Mayor2s = new HashSet<Mayor2>();
            MovBanco2s = new HashSet<MovBanco2>();
            SubtipoDocCb2s = new HashSet<SubtipoDocCb2>();
            SubtipoDocCc2s = new HashSet<SubtipoDocCc2>();
            SubtipoDocCp2s = new HashSet<SubtipoDocCp2>();
        }

        public string TipoAsiento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AsientoDeDiario2> AsientoDeDiario2s { get; set; }
        public virtual ICollection<AsientoDistribuid2> AsientoDistribuid2s { get; set; }
        public virtual ICollection<AsientoMayorizado2> AsientoMayorizado2s { get; set; }
        public virtual ICollection<AsientoRecurrente2> AsientoRecurrente2s { get; set; }
        public virtual ICollection<AsientosCheque2> AsientosCheque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Mayor2> Mayor2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<SubtipoDocCb2> SubtipoDocCb2s { get; set; }
        public virtual ICollection<SubtipoDocCc2> SubtipoDocCc2s { get; set; }
        public virtual ICollection<SubtipoDocCp2> SubtipoDocCp2s { get; set; }
    }
}
