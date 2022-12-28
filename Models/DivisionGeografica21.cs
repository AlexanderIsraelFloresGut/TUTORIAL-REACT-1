using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica21
    {
        public DivisionGeografica21()
        {
            Cotizante1s = new HashSet<Cotizante1>();
            DivisionGeografica31s = new HashSet<DivisionGeografica31>();
            DocsSoporte1s = new HashSet<DocsSoporte1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            ExcepCiudad1s = new HashSet<ExcepCiudad1>();
            MayorDivisionGeografica1s = new HashSet<MayorDivisionGeografica1>();
        }

        public string Pais { get; set; } = null!;
        public string DivisionGeografica1 { get; set; } = null!;
        public string DivisionGeografica2 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DivisionGeografica11 DivisionGeografica11 { get; set; } = null!;
        public virtual ICollection<Cotizante1> Cotizante1s { get; set; }
        public virtual ICollection<DivisionGeografica31> DivisionGeografica31s { get; set; }
        public virtual ICollection<DocsSoporte1> DocsSoporte1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<ExcepCiudad1> ExcepCiudad1s { get; set; }
        public virtual ICollection<MayorDivisionGeografica1> MayorDivisionGeografica1s { get; set; }
    }
}
