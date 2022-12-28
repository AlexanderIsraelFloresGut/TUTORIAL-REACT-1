using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpHistorial2
    {
        public int Id { get; set; }
        public string Planificador { get; set; } = null!;
        public string Conjunto { get; set; } = null!;
        public string Consecutivo { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string ArticuloProveedor { get; set; } = null!;
        public decimal ConsumoPromedio { get; set; }
        public decimal InvMaximo { get; set; }
        public decimal InvTransito { get; set; }
        public decimal InvActual { get; set; }
        public decimal ReferenciaPedido { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal SugerenciaPedido { get; set; }
        public decimal CantidadComprada { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime? FechaHora { get; set; }
        public string? Notas { get; set; }
        public int Fkversion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
