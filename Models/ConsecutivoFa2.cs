using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConsecutivoFa2
    {
        public ConsecutivoFa2()
        {
            ConsecufaUsuario2s = new HashSet<ConsecufaUsuario2>();
            Consecutivo2s = new HashSet<Consecutivo2>();
            Despacho2s = new HashSet<Despacho2>();
            SubtipoDocCc2s = new HashSet<SubtipoDocCc2>();
        }

        public string CodigoConsecutivo { get; set; } = null!;
        public string UsuarioUlt { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public short Longitud { get; set; }
        public string ValorConsecutivo { get; set; } = null!;
        public string? Mascara { get; set; }
        public DateTime FechaHoraUlt { get; set; }
        public string Formato { get; set; } = null!;
        public string UsaDespachos { get; set; } = null!;
        public string UsaEsquemaCajas { get; set; } = null!;
        public string ValorMaximo { get; set; } = null!;
        public int NumeroCopias { get; set; }
        public string? Original { get; set; }
        public string? Copia1 { get; set; }
        public string? Copia2 { get; set; }
        public string? Copia3 { get; set; }
        public string? Copia4 { get; set; }
        public string? Copia5 { get; set; }
        public string? Reimpresion { get; set; }
        public string? Resolucion { get; set; }
        public string? Serie { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? DeConsRpt { get; set; }
        public string? ValorInicial { get; set; }
        public string? DeCcRpt { get; set; }
        public int? MatriculaMercantil { get; set; }

        public virtual ResolucionDocElectronico2? ResolucionNavigation { get; set; }
        public virtual Usuario2 UsuarioUltNavigation { get; set; } = null!;
        public virtual ICollection<ConsecufaUsuario2> ConsecufaUsuario2s { get; set; }
        public virtual ICollection<Consecutivo2> Consecutivo2s { get; set; }
        public virtual ICollection<Despacho2> Despacho2s { get; set; }
        public virtual ICollection<SubtipoDocCc2> SubtipoDocCc2s { get; set; }
    }
}
