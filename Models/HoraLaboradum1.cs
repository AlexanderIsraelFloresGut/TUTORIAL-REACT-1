using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HoraLaboradum1
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

        public virtual CentroCosto1 CentroCostoNavigation { get; set; } = null!;
        public virtual Concepto1 ConceptoNavigation { get; set; } = null!;
        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual NominaHistorico1? N { get; set; }
        public virtual Usuario2? UsuarioCargaNavigation { get; set; }
    }
}
