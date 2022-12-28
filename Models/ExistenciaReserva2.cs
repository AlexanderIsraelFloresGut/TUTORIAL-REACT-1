using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExistenciaReserva2
    {
        public string Articulo { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public int? SerieCadena { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ExistenciaBodega2 ExistenciaBodega2 { get; set; } = null!;
        public virtual Localizacion2 Localizacion2 { get; set; } = null!;
        public virtual Lote2 Lote2 { get; set; } = null!;
        public virtual SerieCadena2? SerieCadenaNavigation { get; set; }
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
