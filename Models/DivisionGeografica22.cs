using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica22
    {
        public DivisionGeografica22()
        {
            Cotizante2s = new HashSet<Cotizante2>();
            DivisionGeografica32s = new HashSet<DivisionGeografica32>();
            DocsSoporte2s = new HashSet<DocsSoporte2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            ExcepCiudad2s = new HashSet<ExcepCiudad2>();
            MayorDivisionGeografica2s = new HashSet<MayorDivisionGeografica2>();
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

        public virtual DivisionGeografica12 DivisionGeografica12 { get; set; } = null!;
        public virtual ICollection<Cotizante2> Cotizante2s { get; set; }
        public virtual ICollection<DivisionGeografica32> DivisionGeografica32s { get; set; }
        public virtual ICollection<DocsSoporte2> DocsSoporte2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<ExcepCiudad2> ExcepCiudad2s { get; set; }
        public virtual ICollection<MayorDivisionGeografica2> MayorDivisionGeografica2s { get; set; }
    }
}
