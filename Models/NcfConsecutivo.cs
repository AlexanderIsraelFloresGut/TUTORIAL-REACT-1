using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class NcfConsecutivo
    {
        public NcfConsecutivo()
        {
            NcfConsecutivoUsuarios = new HashSet<NcfConsecutivoUsuario>();
        }

        public string Prefijo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string UltimoValor { get; set; } = null!;
        public string SecuenciaInicial { get; set; } = null!;
        public string SecuenciaFinal { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? UsuarioCreacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public string? UsuarioAjuste { get; set; }
        public DateTime? FechahoraCreacion { get; set; }
        public DateTime? FechahoraModifica { get; set; }
        public DateTime? FechahoraAjuste { get; set; }
        public string TipoDoc { get; set; } = null!;
        public string TipoContribuyente { get; set; } = null!;
        public string? Sugerir { get; set; }
        public string NcfUnico { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? FechaVencimientoCai { get; set; }
        public DateTime? FechaAutorizacionCai { get; set; }

        public virtual ICollection<NcfConsecutivoUsuario> NcfConsecutivoUsuarios { get; set; }
    }
}
