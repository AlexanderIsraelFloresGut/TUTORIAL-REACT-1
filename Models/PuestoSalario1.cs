using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PuestoSalario1
    {
        public string Puesto { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? MercadoMinimo { get; set; }
        public decimal? MercadoCuartil1 { get; set; }
        public decimal? MercadoCuartil2 { get; set; }
        public decimal? MercadoCuartil3 { get; set; }
        public decimal? MercadoMaximo { get; set; }
        public decimal? SalarioCompania { get; set; }
        public decimal? MercadoPromedio { get; set; }
        public decimal? MercadoModa { get; set; }
        public decimal? MinimoLey { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Puesto1 PuestoNavigation { get; set; } = null!;
    }
}
