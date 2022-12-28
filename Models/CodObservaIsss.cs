using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CodObservaIsss
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Prioridad { get; set; }
        public string? AccionPersonal { get; set; }
        public string? Concepto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoAccion? AccionPersonalNavigation { get; set; }
        public virtual Concepto? ConceptoNavigation { get; set; }
    }
}
