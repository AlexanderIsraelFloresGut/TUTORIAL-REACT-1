using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Administradora1
    {
        public Administradora1()
        {
            AdminConcepto1s = new HashSet<AdminConcepto1>();
            AdminCotizante1s = new HashSet<AdminCotizante1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
        }

        public string Administradora { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoAdministradora { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public string DvNitAdministra { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string DescSucursal { get; set; } = null!;
        public string Municipio { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? AgrupaAporte { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AdminConcepto1> AdminConcepto1s { get; set; }
        public virtual ICollection<AdminCotizante1> AdminCotizante1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
    }
}
