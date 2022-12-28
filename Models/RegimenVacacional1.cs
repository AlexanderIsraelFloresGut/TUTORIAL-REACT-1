using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RegimenVacacional1
    {
        public RegimenVacacional1()
        {
            CalculoVacacional1s = new HashSet<CalculoVacacional1>();
            EmpleadoAccPer1s = new HashSet<EmpleadoAccPer1>();
            EmpleadoSaldoVac1s = new HashSet<EmpleadoSaldoVac1>();
            EmpleadoVacacion1s = new HashSet<EmpleadoVacacion1>();
            RegimenVacContri1s = new HashSet<RegimenVacContri1>();
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

        public virtual TipoAccion1? TipoAccionNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModifNavigation { get; set; } = null!;
        public virtual ICollection<CalculoVacacional1> CalculoVacacional1s { get; set; }
        public virtual ICollection<EmpleadoAccPer1> EmpleadoAccPer1s { get; set; }
        public virtual ICollection<EmpleadoSaldoVac1> EmpleadoSaldoVac1s { get; set; }
        public virtual ICollection<EmpleadoVacacion1> EmpleadoVacacion1s { get; set; }
        public virtual ICollection<RegimenVacContri1> RegimenVacContri1s { get; set; }
    }
}
