using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleDireccion
    {
        public DetalleDireccion()
        {
            Clientes = new HashSet<Cliente>();
            DireccEmbarques = new HashSet<DireccEmbarque>();
            EmpleadoDetalleDirHabNavigations = new HashSet<Empleado>();
            EmpleadoDetalleDirPostalNavigations = new HashSet<Empleado>();
            Proveedors = new HashSet<Proveedor>();
        }

        public int DetalleDireccion1 { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Campo1 { get; set; }
        public string? Campo2 { get; set; }
        public string? Campo3 { get; set; }
        public string? Campo4 { get; set; }
        public string? Campo5 { get; set; }
        public string? Campo6 { get; set; }
        public string? Campo7 { get; set; }
        public string? Campo8 { get; set; }
        public string? Campo9 { get; set; }
        public string? Campo10 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Direccion DireccionNavigation { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<DireccEmbarque> DireccEmbarques { get; set; }
        public virtual ICollection<Empleado> EmpleadoDetalleDirHabNavigations { get; set; }
        public virtual ICollection<Empleado> EmpleadoDetalleDirPostalNavigations { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
