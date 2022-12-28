using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AdicionalNomina4
    {
        public AdicionalNomina4()
        {
            AdicionalNominaValor2s = new HashSet<AdicionalNominaValor2>();
            Adicionalnomina5s = new HashSet<Adicionalnomina5>();
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

        public virtual ICollection<AdicionalNominaValor2> AdicionalNominaValor2s { get; set; }
        public virtual ICollection<Adicionalnomina5> Adicionalnomina5s { get; set; }
    }
}
