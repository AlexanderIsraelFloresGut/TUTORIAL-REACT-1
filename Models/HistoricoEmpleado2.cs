using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HistoricoEmpleado2
    {
        public int NumeroHistorico { get; set; }
        public string Empleado { get; set; } = null!;
        public DateTime UltFechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Puesto { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public decimal Antiguedad { get; set; }
        public decimal PrimerSalario { get; set; }
        public decimal UltimoSalario { get; set; }
        public string? Jefe { get; set; }
        public string RazonSalida { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCosto2 CentroCostoNavigation { get; set; } = null!;
        public virtual Departamento2 DepartamentoNavigation { get; set; } = null!;
        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual Empleado2? JefeNavigation { get; set; }
        public virtual Nomina2 NominaNavigation { get; set; } = null!;
        public virtual Ubicacion2 UbicacionNavigation { get; set; } = null!;
    }
}
