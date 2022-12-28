using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class UsuarioPaquete1
    {
        public string Paquete { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string SoloLectura { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string Agregar { get; set; } = null!;
        public string Eliminar { get; set; } = null!;
        public string Total { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Paquete1 PaqueteNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
