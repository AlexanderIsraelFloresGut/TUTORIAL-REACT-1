using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            CajaChicas = new HashSet<CajaChica>();
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            CelulaTrabajos = new HashSet<CelulaTrabajo>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoAccidentes = new HashSet<EmpleadoAccidente>();
            Empleados = new HashSet<Empleado>();
            Equipos = new HashSet<Equipo>();
            HistoricoEmpleados = new HashSet<HistoricoEmpleado>();
            OrdenCompras = new HashSet<OrdenCompra>();
            Plazas = new HashSet<Plaza>();
            RangosAutorizaDeps = new HashSet<RangosAutorizaDep>();
            SolicitudOcs = new HashSet<SolicitudOc>();
            Vales = new HashSet<Vale>();
        }

        public string Departamento1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Jefe { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Activo { get; set; } = null!;

        public virtual ICollection<CajaChica> CajaChicas { get; set; }
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<CelulaTrabajo> CelulaTrabajos { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoAccidente> EmpleadoAccidentes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<HistoricoEmpleado> HistoricoEmpleados { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<Plaza> Plazas { get; set; }
        public virtual ICollection<RangosAutorizaDep> RangosAutorizaDeps { get; set; }
        public virtual ICollection<SolicitudOc> SolicitudOcs { get; set; }
        public virtual ICollection<Vale> Vales { get; set; }
    }
}
