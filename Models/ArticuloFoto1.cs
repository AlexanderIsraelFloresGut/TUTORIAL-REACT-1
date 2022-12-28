using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloFoto1
    {
        public string Articulo { get; set; } = null!;
        public int Secuencia { get; set; }
        public byte[]? Foto { get; set; }
        public int Prioridad { get; set; }
        public string Archivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaUltModif { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
    }
}
