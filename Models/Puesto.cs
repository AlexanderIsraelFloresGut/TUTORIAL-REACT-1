using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            CelulaPuestos = new HashSet<CelulaPuesto>();
            ConceptoPuestos = new HashSet<ConceptoPuesto>();
            EmpleadoAccidentes = new HashSet<EmpleadoAccidente>();
            EstrucProcMos = new HashSet<EstrucProcMo>();
            OpOperDetMos = new HashSet<OpOperDetMo>();
            OpOperacionMos = new HashSet<OpOperacionMo>();
            OtPlanTrabajos = new HashSet<OtPlanTrabajo>();
            OtPuestos = new HashSet<OtPuesto>();
            OtReporteLabors = new HashSet<OtReporteLabor>();
            Plazas = new HashSet<Plaza>();
            ProcPuestos = new HashSet<ProcPuesto>();
            PtoExternoPuestos = new HashSet<PtoExternoPuesto>();
            PuestoSalarios = new HashSet<PuestoSalario>();
            RolEqPrevents = new HashSet<RolEqPrevent>();
        }

        public string Puesto1 { get; set; } = null!;
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

        public virtual PuestoFuncione PuestoFuncione { get; set; } = null!;
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<CelulaPuesto> CelulaPuestos { get; set; }
        public virtual ICollection<ConceptoPuesto> ConceptoPuestos { get; set; }
        public virtual ICollection<EmpleadoAccidente> EmpleadoAccidentes { get; set; }
        public virtual ICollection<EstrucProcMo> EstrucProcMos { get; set; }
        public virtual ICollection<OpOperDetMo> OpOperDetMos { get; set; }
        public virtual ICollection<OpOperacionMo> OpOperacionMos { get; set; }
        public virtual ICollection<OtPlanTrabajo> OtPlanTrabajos { get; set; }
        public virtual ICollection<OtPuesto> OtPuestos { get; set; }
        public virtual ICollection<OtReporteLabor> OtReporteLabors { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<ProcPuesto> ProcPuestos { get; set; }
        public virtual ICollection<PtoExternoPuesto> PtoExternoPuestos { get; set; }
        public virtual ICollection<PuestoSalario> PuestoSalarios { get; set; }
        public virtual ICollection<RolEqPrevent> RolEqPrevents { get; set; }
    }
}
