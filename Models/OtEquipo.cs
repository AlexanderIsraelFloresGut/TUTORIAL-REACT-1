using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtEquipo
    {
        public int OrdenTrabajo { get; set; }
        public string Equipo { get; set; } = null!;
        public string? EquipoPadre { get; set; }
        public decimal CostoEstMatLoc { get; set; }
        public decimal CostoEstMatDol { get; set; }
        public decimal CostoAcuMatLoc { get; set; }
        public decimal CostoAcuMatDol { get; set; }
        public decimal CostoEstMoLoc { get; set; }
        public decimal CostoEstMoDol { get; set; }
        public decimal CostoAcuMoLoc { get; set; }
        public decimal CostoAcuMoDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Equipo EquipoNavigation { get; set; } = null!;
        public virtual Equipo? EquipoPadreNavigation { get; set; }
        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
    }
}
