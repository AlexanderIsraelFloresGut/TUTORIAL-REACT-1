using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Administradora
    {
        public Administradora()
        {
            AdminConceptos = new HashSet<AdminConcepto>();
            AdminCotizantes = new HashSet<AdminCotizante>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
        }

        public string Administradora1 { get; set; } = null!;
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

        public virtual ICollection<AdminConcepto> AdminConceptos { get; set; }
        public virtual ICollection<AdminCotizante> AdminCotizantes { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
    }
}
