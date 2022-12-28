using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAsiento
    {
        public TipoAsiento()
        {
            AsientoDeDiarios = new HashSet<AsientoDeDiario>();
            AsientoDistribuids = new HashSet<AsientoDistribuid>();
            AsientoMayorizados = new HashSet<AsientoMayorizado>();
            AsientoRecurrentes = new HashSet<AsientoRecurrente>();
            AsientosCheques = new HashSet<AsientosCheque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            Mayors = new HashSet<Mayor>();
            MovBancos = new HashSet<MovBanco>();
            SubtipoDocCbs = new HashSet<SubtipoDocCb>();
            SubtipoDocCcs = new HashSet<SubtipoDocCc>();
            SubtipoDocCps = new HashSet<SubtipoDocCp>();
        }

        public string TipoAsiento1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AsientoDeDiario> AsientoDeDiarios { get; set; }
        public virtual ICollection<AsientoDistribuid> AsientoDistribuids { get; set; }
        public virtual ICollection<AsientoMayorizado> AsientoMayorizados { get; set; }
        public virtual ICollection<AsientoRecurrente> AsientoRecurrentes { get; set; }
        public virtual ICollection<AsientosCheque> AsientosCheques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Mayor> Mayors { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<SubtipoDocCb> SubtipoDocCbs { get; set; }
        public virtual ICollection<SubtipoDocCc> SubtipoDocCcs { get; set; }
        public virtual ICollection<SubtipoDocCp> SubtipoDocCps { get; set; }
    }
}
