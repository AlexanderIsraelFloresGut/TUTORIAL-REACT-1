using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Consecutivo
    {
        public Consecutivo()
        {
            ConsecutivoUsuarios = new HashSet<ConsecutivoUsuario>();
            Regimenes = new HashSet<Regimene>();
        }

        public string Consecutivo1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Activo { get; set; } = null!;
        public decimal Longitud { get; set; }
        public string Entidad { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? FormatoImpresionDetallado { get; set; }
        public string? FormatoImpresionResumido { get; set; }
        public string Mascara { get; set; } = null!;
        public string ValorInicial { get; set; } = null!;
        public string ValorFinal { get; set; } = null!;
        public string UltimoValor { get; set; } = null!;
        public string UltimoUsuario { get; set; } = null!;
        public DateTime FechaHoraUlt { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? ConsecutivoNc { get; set; }

        public virtual ConsecutivoFa? ConsecutivoNcNavigation { get; set; }
        public virtual ICollection<ConsecutivoUsuario> ConsecutivoUsuarios { get; set; }
        public virtual ICollection<Regimene> Regimenes { get; set; }
    }
}
