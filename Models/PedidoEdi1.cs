using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PedidoEdi1
    {
        public PedidoEdi1()
        {
            LineaspedidoEdi1s = new HashSet<LineaspedidoEdi1>();
        }

        public string Numeroorden { get; set; } = null!;
        public string GlnComprador { get; set; } = null!;
        public string? Pedido { get; set; }
        public string CedulajuridicaComprador { get; set; } = null!;
        public string Nombreempresacomprador { get; set; } = null!;
        public string? DepartamentoComprador { get; set; }
        public string? ContactoComprador { get; set; }
        public string? TelefonoComprador { get; set; }
        public string? Urgente { get; set; }
        public string? PortonEntrega { get; set; }
        public string? InformacionAdicional { get; set; }
        public DateTime FechaEmisionOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string? GlnLugarentrega { get; set; }
        public string? CedulajuridicaLugarentrega { get; set; }
        public string? NombreEmpresaLugarentrega { get; set; }
        public string? DepartamentoLugarentrega { get; set; }
        public string? ContactoLugarentrega { get; set; }
        public string? TelefonoLugarentrega { get; set; }
        public decimal TotalOrden { get; set; }
        public decimal SubtotalOrden { get; set; }
        public decimal TotalImpuestos { get; set; }
        public decimal TotalDescuentos { get; set; }
        public string Estado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<LineaspedidoEdi1> LineaspedidoEdi1s { get; set; }
    }
}
