using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Departamento1
    {
        public Departamento1()
        {
            CajaChica1s = new HashSet<CajaChica1>();
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            CelulaTrabajo1s = new HashSet<CelulaTrabajo1>();
            CsAreaOrgs = new HashSet<CsAreaOrg>();
            Empleado1s = new HashSet<Empleado1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoAccidente1s = new HashSet<EmpleadoAccidente1>();
            Equipo1s = new HashSet<Equipo1>();
            HistoricoEmpleado1s = new HashSet<HistoricoEmpleado1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            Plaza1s = new HashSet<Plaza1>();
            RangosAutorizaDep1s = new HashSet<RangosAutorizaDep1>();
            SolicitudOc1s = new HashSet<SolicitudOc1>();
            Vale1s = new HashSet<Vale1>();
        }

        public string Departamento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Jefe { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Activo { get; set; } = null!;

        public virtual ICollection<CajaChica1> CajaChica1s { get; set; }
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<CelulaTrabajo1> CelulaTrabajo1s { get; set; }
        public virtual ICollection<CsAreaOrg> CsAreaOrgs { get; set; }
        public virtual ICollection<Empleado1> Empleado1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoAccidente1> EmpleadoAccidente1s { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<HistoricoEmpleado1> HistoricoEmpleado1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<Plaza1> Plaza1s { get; set; }
        public virtual ICollection<RangosAutorizaDep1> RangosAutorizaDep1s { get; set; }
        public virtual ICollection<SolicitudOc1> SolicitudOc1s { get; set; }
        public virtual ICollection<Vale1> Vale1s { get; set; }
    }
}
