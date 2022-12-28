using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleDireccion2
    {
        public DetalleDireccion2()
        {
            Cliente2s = new HashSet<Cliente2>();
            DireccEmbarque2s = new HashSet<DireccEmbarque2>();
            Empleado2DetalleDirHabNavigations = new HashSet<Empleado2>();
            Empleado2DetalleDirPostalNavigations = new HashSet<Empleado2>();
            Proveedor2s = new HashSet<Proveedor2>();
        }

        public int DetalleDireccion { get; set; }
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

        public virtual Direccion2 DireccionNavigation { get; set; } = null!;
        public virtual ICollection<Cliente2> Cliente2s { get; set; }
        public virtual ICollection<DireccEmbarque2> DireccEmbarque2s { get; set; }
        public virtual ICollection<Empleado2> Empleado2DetalleDirHabNavigations { get; set; }
        public virtual ICollection<Empleado2> Empleado2DetalleDirPostalNavigations { get; set; }
        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
    }
}
