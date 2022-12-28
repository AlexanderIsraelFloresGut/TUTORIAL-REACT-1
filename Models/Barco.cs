using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Barco
    {
        public Barco()
        {
            BarcoActividads = new HashSet<BarcoActividad>();
            BarcoFaenaEscamas = new HashSet<BarcoFaenaEscama>();
            BarcoFaenaLangosta = new HashSet<BarcoFaenaLangostum>();
        }

        public int Id { get; set; }
        public string Barco1 { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool Activo { get; set; }
        public bool Propio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string HostName { get; set; } = null!;

        public virtual ICollection<BarcoActividad> BarcoActividads { get; set; }
        public virtual ICollection<BarcoFaenaEscama> BarcoFaenaEscamas { get; set; }
        public virtual ICollection<BarcoFaenaLangostum> BarcoFaenaLangosta { get; set; }
    }
}
