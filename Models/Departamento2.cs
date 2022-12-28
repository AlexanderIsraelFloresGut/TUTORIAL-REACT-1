using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Departamento2
    {
        public Departamento2()
        {
            CajaChica2s = new HashSet<CajaChica2>();
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            Empleado2s = new HashSet<Empleado2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoAccidente2s = new HashSet<EmpleadoAccidente2>();
            HistoricoEmpleado2s = new HashSet<HistoricoEmpleado2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            Plaza2s = new HashSet<Plaza2>();
            RangosAutorizaDep2s = new HashSet<RangosAutorizaDep2>();
            SolicitudOc2s = new HashSet<SolicitudOc2>();
            Vale2s = new HashSet<Vale2>();
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

        public virtual ICollection<CajaChica2> CajaChica2s { get; set; }
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoAccidente2> EmpleadoAccidente2s { get; set; }
        public virtual ICollection<HistoricoEmpleado2> HistoricoEmpleado2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<Plaza2> Plaza2s { get; set; }
        public virtual ICollection<RangosAutorizaDep2> RangosAutorizaDep2s { get; set; }
        public virtual ICollection<SolicitudOc2> SolicitudOc2s { get; set; }
        public virtual ICollection<Vale2> Vale2s { get; set; }
    }
}
