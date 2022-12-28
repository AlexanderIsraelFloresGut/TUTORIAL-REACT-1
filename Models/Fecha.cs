using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Fecha
    {
        public DateTime Fecha1 { get; set; }
        public string? FechaNombre { get; set; }
        public DateTime? Año { get; set; }
        public string? AñoNombre { get; set; }
        public DateTime? Semestre { get; set; }
        public string? SemestreNombre { get; set; }
        public DateTime? Trimestre { get; set; }
        public string? TrimestreNombre { get; set; }
        public DateTime? Mes { get; set; }
        public string? MesNombre { get; set; }
        public int? DíaDelAño { get; set; }
        public string? DíaDelAñoNombre { get; set; }
        public int? DíaDelSemestre { get; set; }
        public string? DíaDelSemestreNombre { get; set; }
        public int? DíaDelTrimestre { get; set; }
        public string? DíaDelTrimestreNombre { get; set; }
        public int? DíaDelMes { get; set; }
        public string? DíaDelMesNombre { get; set; }
        public int? MesDelAño { get; set; }
        public string? MesDelAñoNombre { get; set; }
        public int? MesDelSemestre { get; set; }
        public string? MesDelSemestreNombre { get; set; }
        public int? MesDelTrimestre { get; set; }
        public string? MesDelTrimestreNombre { get; set; }
        public int? TrimestreDelAño { get; set; }
        public string? TrimestreDelAñoNombre { get; set; }
        public int? TrimestreDelSemestre { get; set; }
        public string? TrimestreDelSemestreNombre { get; set; }
        public int? SemestreDelAño { get; set; }
        public string? SemestreDelAñoNombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
