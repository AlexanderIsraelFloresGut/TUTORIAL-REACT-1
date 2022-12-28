using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConceptoUsuario1
    {
        public string Concepto { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Privilegio { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto1 ConceptoNavigation { get; set; } = null!;
        public virtual Nomina1 NominaNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
