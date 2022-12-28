using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BeneficiosAntigue2
    {
        public string Nomina { get; set; } = null!;
        public decimal DiasAntiguedad { get; set; }
        public decimal DiasVacaciones { get; set; }
        public decimal DiasAguinaldo { get; set; }
        public decimal PorcPrimaVac { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
