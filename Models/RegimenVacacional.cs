using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class RegimenVacacional
    {
        public RegimenVacacional()
        {
            CalculoVacacionals = new HashSet<CalculoVacacional>();
            EmpleadoAccPers = new HashSet<EmpleadoAccPer>();
            EmpleadoSaldoVacs = new HashSet<EmpleadoSaldoVac>();
            EmpleadoVacacions = new HashSet<EmpleadoVacacion>();
            RegimenVacContris = new HashSet<RegimenVacContri>();
        }

        public string RegimenVacacional1 { get; set; } = null!;
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

        public virtual TipoAccion? TipoAccionNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioUltModifNavigation { get; set; } = null!;
        public virtual ICollection<CalculoVacacional> CalculoVacacionals { get; set; }
        public virtual ICollection<EmpleadoAccPer> EmpleadoAccPers { get; set; }
        public virtual ICollection<EmpleadoSaldoVac> EmpleadoSaldoVacs { get; set; }
        public virtual ICollection<EmpleadoVacacion> EmpleadoVacacions { get; set; }
        public virtual ICollection<RegimenVacContri> RegimenVacContris { get; set; }
    }
}
