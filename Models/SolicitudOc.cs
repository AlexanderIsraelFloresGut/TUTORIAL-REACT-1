using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudOc
    {
        public SolicitudOc()
        {
            PedidoSugeridos = new HashSet<PedidoSugerido>();
            SolicitudOcImps = new HashSet<SolicitudOcImp>();
            SolicitudOcLineas = new HashSet<SolicitudOcLinea>();
        }

        public string SolicitudOc1 { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaRequerida { get; set; }
        public string? AutorizadaPor { get; set; }
        public DateTime? FechaAutorizada { get; set; }
        public string Prioridad { get; set; } = null!;
        public short LineasNoAsig { get; set; }
        public string Estado { get; set; } = null!;
        public string? Comentario { get; set; }
        public DateTime FechaHora { get; set; }
        public string? Usuario { get; set; }
        public string? UsuarioCancela { get; set; }
        public DateTime? FechaHoraCancela { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? UFechaCotizacion { get; set; }
        public DateTime? UFechaAprob2 { get; set; }
        public string? UAutorizadaPor2 { get; set; }

        public virtual Usuario2? AutorizadaPorNavigation { get; set; }
        public virtual Departamento DepartamentoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridos { get; set; }
        public virtual ICollection<SolicitudOcImp> SolicitudOcImps { get; set; }
        public virtual ICollection<SolicitudOcLinea> SolicitudOcLineas { get; set; }
    }
}
