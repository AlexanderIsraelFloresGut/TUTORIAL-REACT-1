using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BoletaInvFisico1
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

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Localizacion1? Localizacion1 { get; set; }
        public virtual Lote1? Lote1 { get; set; }
        public virtual SerieCadena1? SerieCadenaDispNavigation { get; set; }
        public virtual SerieCadena1? SerieCadenaNoaprNavigation { get; set; }
        public virtual SerieCadena1? SerieCadenaVencNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
