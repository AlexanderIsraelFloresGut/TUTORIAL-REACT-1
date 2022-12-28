using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DivisionGeografica2
    {
        public DivisionGeografica2()
        {
            Cotizantes = new HashSet<Cotizante>();
            DivisionGeografica3s = new HashSet<DivisionGeografica3>();
            DocsSoportes = new HashSet<DocsSoporte>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCps = new HashSet<DocumentosCp>();
            ExcepCiudads = new HashSet<ExcepCiudad>();
            MayorDivisionGeograficas = new HashSet<MayorDivisionGeografica>();
        }

        public string Pais { get; set; } = null!;
        public string DivisionGeografica1 { get; set; } = null!;
        public string DivisionGeografica21 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DivisionGeografica1 DivisionGeografica1Navigation { get; set; } = null!;
        public virtual ICollection<Cotizante> Cotizantes { get; set; }
        public virtual ICollection<DivisionGeografica3> DivisionGeografica3s { get; set; }
        public virtual ICollection<DocsSoporte> DocsSoportes { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<ExcepCiudad> ExcepCiudads { get; set; }
        public virtual ICollection<MayorDivisionGeografica> MayorDivisionGeograficas { get; set; }
    }
}
