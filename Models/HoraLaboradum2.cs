using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HoraLaboradum2
    {
        public int Consecutivo { get; set; }
        public string Empleado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public DateTime FechaLaborada { get; set; }
        public decimal CantidadHoras { get; set; }
        public string? Observaciones { get; set; }
        public string Cargado { get; set; } = null!;
        public string? UsuarioCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string? Nomina { get; set; }
        public short? NumeroNomina { get; set; }
        public string? Fase { get; set; }
        public string? Proyecto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual Concepto2 ConceptoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico2? N { get; set; }
        public virtual Usuario2? UsuarioCargaNavigation { get; set; }
    }
}
