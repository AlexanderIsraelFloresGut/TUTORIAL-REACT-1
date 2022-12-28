using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BoletaInvFisico
    {
        public string Boleta { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string? Localizacion { get; set; }
        public string? Lote { get; set; }
        public decimal CantDispReserv { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Validada { get; set; } = null!;
        public int? SerieCadenaDisp { get; set; }
        public int? SerieCadenaNoapr { get; set; }
        public int? SerieCadenaVenc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Localizacion? LocalizacionNavigation { get; set; }
        public virtual Lote? LoteNavigation { get; set; }
        public virtual SerieCadena? SerieCadenaDispNavigation { get; set; }
        public virtual SerieCadena? SerieCadenaNoaprNavigation { get; set; }
        public virtual SerieCadena? SerieCadenaVencNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
