using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RegimenVacacional2
    {
        public RegimenVacacional2()
        {
            CalculoVacacional2s = new HashSet<CalculoVacacional2>();
            EmpleadoAccPer2s = new HashSet<EmpleadoAccPer2>();
            EmpleadoSaldoVac2s = new HashSet<EmpleadoSaldoVac2>();
            EmpleadoVacacion2s = new HashSet<EmpleadoVacacion2>();
            RegimenVacContri2s = new HashSet<RegimenVacContri2>();
        }

        public string RegimenVacacional { get; set; } = null!;
        public string UsuarioCreacion { get; set; } = null!;
        public string? TipoAccion { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string AgrupaCalculo { get; set; } = null!;
        public string EliminarContCero { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltModif { get; set; }
        public string? Notas { get; set; }
        public string UsuarioUltModif { get; set; } = null!;
        public string? TipoAnno { get; set; }
        public string? TipoFecha { get; set; }
        public string? IncluirSabados { get; set; }
        public string? IncluirDomingos { get; set; }
        public string? IncluirFeriados { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoAccion2? TipoAccionNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModifNavigation { get; set; } = null!;
        public virtual ICollection<CalculoVacacional2> CalculoVacacional2s { get; set; }
        public virtual ICollection<EmpleadoAccPer2> EmpleadoAccPer2s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac2> EmpleadoSaldoVac2s { get; set; }
        public virtual ICollection<EmpleadoVacacion2> EmpleadoVacacion2s { get; set; }
        public virtual ICollection<RegimenVacContri2> RegimenVacContri2s { get; set; }
    }
}
