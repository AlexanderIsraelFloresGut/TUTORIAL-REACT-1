using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Direccion2
    {
        public Direccion2()
        {
            DetalleDireccion2s = new HashSet<DetalleDireccion2>();
            Pai2s = new HashSet<Pai2>();
        }

        public string Direccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? NombreCampo1 { get; set; }
        public string? NombreCampo2 { get; set; }
        public string? NombreCampo3 { get; set; }
        public string? NombreCampo4 { get; set; }
        public string? NombreCampo5 { get; set; }
        public string? NombreCampo6 { get; set; }
        public string? NombreCampo7 { get; set; }
        public string? NombreCampo8 { get; set; }
        public string? NombreCampo9 { get; set; }
        public string? NombreCampo10 { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UsuarioUltModif { get; set; } = null!;
        public DateTime FechaUltModif { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DetalleDireccion2> DetalleDireccion2s { get; set; }
        public virtual ICollection<Pai2> Pai2s { get; set; }
    }
}
