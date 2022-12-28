using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Metum1
    {
        public Metum1()
        {
            MetaDetalle1s = new HashSet<MetaDetalle1>();
        }

        public int Meta { get; set; }
        public string Cubo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime Periodoinicial { get; set; }
        public int Cantidadperiodos { get; set; }
        public string Nombrereal { get; set; } = null!;
        public string Nombrepresupuesto { get; set; } = null!;
        public string Medida { get; set; } = null!;
        public string NombreMedida { get; set; } = null!;
        public string Dimensionprincipal { get; set; } = null!;
        public string NombreDimensionprincipal { get; set; } = null!;
        public string? Dimensionagrupamiento { get; set; }
        public string? NombreDimensionagrupamiento { get; set; }
        public decimal Limitesobresaliente { get; set; }
        public decimal Limiteexitoso { get; set; }
        public decimal Limitedeficiente { get; set; }
        public decimal Limitecritico { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuboPrivilegio1 CuboNavigation { get; set; } = null!;
        public virtual ICollection<MetaDetalle1> MetaDetalle1s { get; set; }
    }
}
