using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetalleDireccion1
    {
        public DetalleDireccion1()
        {
            Cliente1s = new HashSet<Cliente1>();
            DireccEmbarque1s = new HashSet<DireccEmbarque1>();
            Empleado1DetalleDirHabNavigations = new HashSet<Empleado1>();
            Empleado1DetalleDirPostalNavigations = new HashSet<Empleado1>();
            Proveedor1s = new HashSet<Proveedor1>();
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

        public virtual Direccion1 DireccionNavigation { get; set; } = null!;
        public virtual ICollection<Cliente1> Cliente1s { get; set; }
        public virtual ICollection<DireccEmbarque1> DireccEmbarque1s { get; set; }
        public virtual ICollection<Empleado1> Empleado1DetalleDirHabNavigations { get; set; }
        public virtual ICollection<Empleado1> Empleado1DetalleDirPostalNavigations { get; set; }
        public virtual ICollection<Proveedor1> Proveedor1s { get; set; }
    }
}
