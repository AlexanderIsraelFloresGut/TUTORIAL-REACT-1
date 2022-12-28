using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpcionConfig
    {
        public int Accion { get; set; }
        public string OpcionConfig1 { get; set; } = null!;
        public int Modulo { get; set; }
        public string Menu { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Notas { get; set; }
        public string Ejecutable { get; set; } = null!;
        public string? Parametros { get; set; }
        public string Activa { get; set; } = null!;
        public string UsuarioCreador { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string UltimoUsuario { get; set; } = null!;
        public DateTime FechaUltAcceso { get; set; }
        public int? Mantenimiento { get; set; }
        public string? NombreImagen { get; set; }
        public string? Imagen { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Accion AccionNavigation { get; set; } = null!;
        public virtual Accion? MantenimientoNavigation { get; set; }
        public virtual Accion ModuloNavigation { get; set; } = null!;
        public virtual Usuario2 UltimoUsuarioNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioCreadorNavigation { get; set; } = null!;
    }
}
