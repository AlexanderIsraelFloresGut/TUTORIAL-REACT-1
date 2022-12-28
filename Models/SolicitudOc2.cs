using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SolicitudOc2
    {
        public SolicitudOc2()
        {
            PedidoSugerido2s = new HashSet<PedidoSugerido2>();
            SolicitudOcImp2s = new HashSet<SolicitudOcImp2>();
            SolicitudOcLinea2s = new HashSet<SolicitudOcLinea2>();
        }

        public string SolicitudOc { get; set; } = null!;
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

        public virtual Usuario2? AutorizadaPorNavigation { get; set; }
        public virtual Departamento2 DepartamentoNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioCancelaNavigation { get; set; }
        public virtual Usuario2? UsuarioNavigation { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2s { get; set; }
        public virtual ICollection<SolicitudOcImp2> SolicitudOcImp2s { get; set; }
        public virtual ICollection<SolicitudOcLinea2> SolicitudOcLinea2s { get; set; }
    }
}
