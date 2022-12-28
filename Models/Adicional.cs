using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Adicional
    {
        public Adicional()
        {
            AdicionalValors = new HashSet<AdicionalValor>();
            Adicionalempleados = new HashSet<Adicionalempleado>();
        }

        public string Adicional1 { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int? Longitud { get; set; }
        public int? Decimales { get; set; }
        public string Modificable { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AdicionalValor> AdicionalValors { get; set; }
        public virtual ICollection<Adicionalempleado> Adicionalempleados { get; set; }
    }
}
