using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Puesto2
    {
        public Puesto2()
        {
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            ConceptoPuesto2s = new HashSet<ConceptoPuesto2>();
            EmpleadoAccidente2s = new HashSet<EmpleadoAccidente2>();
            OpOperDetMo2s = new HashSet<OpOperDetMo2>();
            OpOperacionMo2s = new HashSet<OpOperacionMo2>();
            Plaza2s = new HashSet<Plaza2>();
            PtoExternoPuesto2s = new HashSet<PtoExternoPuesto2>();
            PuestoSalario2s = new HashSet<PuestoSalario2>();
        }

        public string Puesto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? SalarioMinimo { get; set; }
        public decimal? SalarioInterm1 { get; set; }
        public decimal? SalarioInterm2 { get; set; }
        public decimal? SalarioMaximo { get; set; }
        public decimal? SalarioActual { get; set; }
        public string ConsecutivoPlaza { get; set; } = null!;
        public string? Notas { get; set; }
        public string Activo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PuestoFuncione2 PuestoFuncione2 { get; set; } = null!;
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<ConceptoPuesto2> ConceptoPuesto2s { get; set; }
        public virtual ICollection<EmpleadoAccidente2> EmpleadoAccidente2s { get; set; }
        public virtual ICollection<OpOperDetMo2> OpOperDetMo2s { get; set; }
        public virtual ICollection<OpOperacionMo2> OpOperacionMo2s { get; set; }
        public virtual ICollection<Plaza2> Plaza2s { get; set; }
        public virtual ICollection<PtoExternoPuesto2> PtoExternoPuesto2s { get; set; }
        public virtual ICollection<PuestoSalario2> PuestoSalario2s { get; set; }
    }
}
