using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Puesto1
    {
        public Puesto1()
        {
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            CelulaPuesto1s = new HashSet<CelulaPuesto1>();
            ConceptoPuesto1s = new HashSet<ConceptoPuesto1>();
            EmpleadoAccidente1s = new HashSet<EmpleadoAccidente1>();
            EstrucProcMo1s = new HashSet<EstrucProcMo1>();
            OpOperDetMo1s = new HashSet<OpOperDetMo1>();
            OpOperacionMo1s = new HashSet<OpOperacionMo1>();
            OtPlanTrabajo1s = new HashSet<OtPlanTrabajo1>();
            OtPuesto1s = new HashSet<OtPuesto1>();
            OtReporteLabor1s = new HashSet<OtReporteLabor1>();
            Plaza1s = new HashSet<Plaza1>();
            ProcPuesto1s = new HashSet<ProcPuesto1>();
            PtoExternoPuesto1s = new HashSet<PtoExternoPuesto1>();
            PuestoSalario1s = new HashSet<PuestoSalario1>();
            RolEqPrevent1s = new HashSet<RolEqPrevent1>();
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

        public virtual PuestoFuncione1 PuestoFuncione1 { get; set; } = null!;
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<CelulaPuesto1> CelulaPuesto1s { get; set; }
        public virtual ICollection<ConceptoPuesto1> ConceptoPuesto1s { get; set; }
        public virtual ICollection<EmpleadoAccidente1> EmpleadoAccidente1s { get; set; }
        public virtual ICollection<EstrucProcMo1> EstrucProcMo1s { get; set; }
        public virtual ICollection<OpOperDetMo1> OpOperDetMo1s { get; set; }
        public virtual ICollection<OpOperacionMo1> OpOperacionMo1s { get; set; }
        public virtual ICollection<OtPlanTrabajo1> OtPlanTrabajo1s { get; set; }
        public virtual ICollection<OtPuesto1> OtPuesto1s { get; set; }
        public virtual ICollection<OtReporteLabor1> OtReporteLabor1s { get; set; }
        public virtual ICollection<Plaza1> Plaza1s { get; set; }
        public virtual ICollection<ProcPuesto1> ProcPuesto1s { get; set; }
        public virtual ICollection<PtoExternoPuesto1> PtoExternoPuesto1s { get; set; }
        public virtual ICollection<PuestoSalario1> PuestoSalario1s { get; set; }
        public virtual ICollection<RolEqPrevent1> RolEqPrevent1s { get; set; }
    }
}
