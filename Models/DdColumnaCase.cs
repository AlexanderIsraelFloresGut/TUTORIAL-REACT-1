using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdColumnaCase
    {
        public DdColumnaCase()
        {
            DdColumnasFormulas = new HashSet<DdColumnasFormula>();
            DdFormulaCases = new HashSet<DdFormulaCase>();
        }

        public Guid IdCase { get; set; }
        public string? ColumnaCase { get; set; }
        public string Tabla { get; set; } = null!;
        public int Entidad { get; set; }
        public string? Tipo { get; set; }
        public string? PropietarioTabla { get; set; }
        public string? AliasCampo { get; set; }
        public string Alias { get; set; } = null!;
        public string TipoColumn { get; set; } = null!;
        public string? TamanoColumn { get; set; }
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdEntidadTabla DdEntidadTabla { get; set; } = null!;
        public virtual ICollection<DdColumnasFormula> DdColumnasFormulas { get; set; }
        public virtual ICollection<DdFormulaCase> DdFormulaCases { get; set; }
    }
}
