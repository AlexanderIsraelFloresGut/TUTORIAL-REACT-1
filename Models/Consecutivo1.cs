using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Consecutivo1
    {
        public Consecutivo1()
        {
            ConsecutivoUsuario1s = new HashSet<ConsecutivoUsuario1>();
            Regimene1s = new HashSet<Regimene1>();
        }

        public string Consecutivo { get; set; } = null!;
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
        public string? UsaImpFiscal { get; set; }

        public virtual ConsecutivoFa1? ConsecutivoNcNavigation { get; set; }
        public virtual ICollection<ConsecutivoUsuario1> ConsecutivoUsuario1s { get; set; }
        public virtual ICollection<Regimene1> Regimene1s { get; set; }
    }
}
