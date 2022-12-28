using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDetMo2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public short SecuenciaMo { get; set; }
        public string Puesto { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public string TipoManoObra { get; set; } = null!;
        public string? Nomina { get; set; }
        public string? Concepto { get; set; }
        public short ConsecutivoNomi { get; set; }
        public decimal CantidadHoras { get; set; }
        public string ExportadoNomina { get; set; } = null!;
        public decimal CostoPorHoraLoc { get; set; }
        public decimal? CostoPorHoraDol { get; set; }
        public string? Notas { get; set; }
        public string? Horario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public Guid? RowpointerMarReloj { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual FactorAjuHora2? HorarioNavigation { get; set; }
        public virtual NominaConcepto2? NominaConcepto2 { get; set; }
        public virtual OpOperDet2 OpOperDet2 { get; set; } = null!;
        public virtual Puesto2 PuestoNavigation { get; set; } = null!;
    }
}
