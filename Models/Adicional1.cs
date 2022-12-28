using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Adicional1
    {
        public Adicional1()
        {
            AdicionalValor1s = new HashSet<AdicionalValor1>();
            Adicionalempleado1s = new HashSet<Adicionalempleado1>();
        }

        public string Adicional { get; set; } = null!;
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

        public virtual ICollection<AdicionalValor1> AdicionalValor1s { get; set; }
        public virtual ICollection<Adicionalempleado1> Adicionalempleado1s { get; set; }
    }
}
