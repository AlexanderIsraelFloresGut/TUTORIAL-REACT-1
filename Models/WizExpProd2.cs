using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class WizExpProd2
    {
        public short? Nivel { get; set; }
        public int Orden { get; set; }
        public string? Articulo { get; set; }
        public decimal? CantEstandar { get; set; }
        public decimal? CantProduc { get; set; }
        public decimal? CostoPromLoc { get; set; }
        public decimal? CostoPromDol { get; set; }
        public decimal? CostoStdLoc { get; set; }
        public decimal? CostoStdDol { get; set; }
        public string? BodegaMp { get; set; }
        public string? BodegaPt { get; set; }
        public string? Estructura { get; set; }
        public string? Version { get; set; }
        public string? Operacion { get; set; }
        public string? Tipo { get; set; }
        public string? Unidad { get; set; }
        public string? UsaSeries { get; set; }
        public string? Padre { get; set; }
        public string? OrdenReal { get; set; }
        public string? OrdenesPadre { get; set; }
        public string? Notas { get; set; }
        public string? Sustituto { get; set; }
        public int? OrdenPadre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
