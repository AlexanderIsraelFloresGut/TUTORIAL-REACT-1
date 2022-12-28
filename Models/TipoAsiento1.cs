using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAsiento1
    {
        public TipoAsiento1()
        {
            AsientoDeDiario1s = new HashSet<AsientoDeDiario1>();
            AsientoDistribuid1s = new HashSet<AsientoDistribuid1>();
            AsientoMayorizado1s = new HashSet<AsientoMayorizado1>();
            AsientoRecurrente1s = new HashSet<AsientoRecurrente1>();
            AsientosCheque1s = new HashSet<AsientosCheque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Mayor1s = new HashSet<Mayor1>();
            MovBanco1s = new HashSet<MovBanco1>();
            SubtipoDocCb1s = new HashSet<SubtipoDocCb1>();
            SubtipoDocCc1s = new HashSet<SubtipoDocCc1>();
            SubtipoDocCp1s = new HashSet<SubtipoDocCp1>();
        }

        public string TipoAsiento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AsientoDeDiario1> AsientoDeDiario1s { get; set; }
        public virtual ICollection<AsientoDistribuid1> AsientoDistribuid1s { get; set; }
        public virtual ICollection<AsientoMayorizado1> AsientoMayorizado1s { get; set; }
        public virtual ICollection<AsientoRecurrente1> AsientoRecurrente1s { get; set; }
        public virtual ICollection<AsientosCheque1> AsientosCheque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Mayor1> Mayor1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<SubtipoDocCb1> SubtipoDocCb1s { get; set; }
        public virtual ICollection<SubtipoDocCc1> SubtipoDocCc1s { get; set; }
        public virtual ICollection<SubtipoDocCp1> SubtipoDocCp1s { get; set; }
    }
}
