using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Administradora2
    {
        public Administradora2()
        {
            AdminConcepto2s = new HashSet<AdminConcepto2>();
            AdminCotizante2s = new HashSet<AdminCotizante2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
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

        public virtual ICollection<AdminConcepto2> AdminConcepto2s { get; set; }
        public virtual ICollection<AdminCotizante2> AdminCotizante2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
    }
}
