using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ProcEquipo1
    {
        public string Equipo { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public string Version { get; set; } = null!;
        public decimal Periodicidad { get; set; }
        public string Frecuencia { get; set; } = null!;
        public string ModalidadRegistro { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string? UsuarioModif { get; set; }
        public DateTime? FechaHoraModif { get; set; }
        public string? Notas { get; set; }
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual Procedimiento1 Procedimiento1 { get; set; } = null!;
        public virtual Usuario2? UsuarioModifNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
