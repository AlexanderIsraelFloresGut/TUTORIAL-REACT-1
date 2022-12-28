using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EstrucHistoric
    {
        public string Estructura { get; set; } = null!;
        public string Version { get; set; } = null!;
        public short Referencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal? CostoAjuLoc { get; set; }
        public decimal? CostoAjuDol { get; set; }
        public decimal? CostoLoc { get; set; }
        public decimal? CostoDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EstrucManufactura EstrucManufactura { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
