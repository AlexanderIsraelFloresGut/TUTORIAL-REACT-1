using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AdicionalNomina2
    {
        public AdicionalNomina2()
        {
            AdicionalNominaValor1s = new HashSet<AdicionalNominaValor1>();
            Adicionalnomina3s = new HashSet<Adicionalnomina3>();
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

        public virtual ICollection<AdicionalNominaValor1> AdicionalNominaValor1s { get; set; }
        public virtual ICollection<Adicionalnomina3> Adicionalnomina3s { get; set; }
    }
}
