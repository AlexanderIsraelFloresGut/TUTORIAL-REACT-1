using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Bodega
    {
        public Bodega()
        {
            ArticuloCompras = new HashSet<ArticuloCompra>();
            BodegaEncargados = new HashSet<BodegaEncargado>();
            CostStdBatches = new HashSet<CostStdBatch>();
            CostoStdDesgls = new HashSet<CostoStdDesgl>();
            CsParametrosPrBodegaMpNavigations = new HashSet<CsParametrosPr>();
            CsParametrosPrBodegaPtNavigations = new HashSet<CsParametrosPr>();
            DespachoDetalles = new HashSet<DespachoDetalle>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            ExistenciaBodegas = new HashSet<ExistenciaBodega>();
            ExistenciaCierres = new HashSet<ExistenciaCierre>();
            FacturaLineas = new HashSet<FacturaLinea>();
            Localizacions = new HashSet<Localizacion>();
            OpOperDetProds = new HashSet<OpOperDetProd>();
            OrdenCompraLineas = new HashSet<OrdenCompraLinea>();
            OrdenCompras = new HashSet<OrdenCompra>();
            OrdenProduccionBodegaMpNavigations = new HashSet<OrdenProduccion>();
            OrdenProduccionBodegaPtNavigations = new HashSet<OrdenProduccion>();
            OrdenTrabajos = new HashSet<OrdenTrabajo>();
            PedidoLineas = new HashSet<PedidoLinea>();
            Pedidos = new HashSet<Pedido>();
            SpPronosticoDetalles = new HashSet<SpPronosticoDetalle>();
            UsuarioBodegas = new HashSet<UsuarioBodega>();
        }

        public string Bodega1 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? ConsecTraslados { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? USucursal { get; set; }
        public string? UCoordinadas { get; set; }
        public string? CodigoEstablecimiento { get; set; }
        public string MercadoLibre { get; set; } = null!;

        public virtual ConsecutivoCi? ConsecTrasladosNavigation { get; set; }
        public virtual BodCargaManuf BodCargaManuf { get; set; } = null!;
        public virtual ICollection<ArticuloCompra> ArticuloCompras { get; set; }
        public virtual ICollection<BodegaEncargado> BodegaEncargados { get; set; }
        public virtual ICollection<CostStdBatch> CostStdBatches { get; set; }
        public virtual ICollection<CostoStdDesgl> CostoStdDesgls { get; set; }
        public virtual ICollection<CsParametrosPr> CsParametrosPrBodegaMpNavigations { get; set; }
        public virtual ICollection<CsParametrosPr> CsParametrosPrBodegaPtNavigations { get; set; }
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<ExistenciaBodega> ExistenciaBodegas { get; set; }
        public virtual ICollection<ExistenciaCierre> ExistenciaCierres { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineas { get; set; }
        public virtual ICollection<Localizacion> Localizacions { get; set; }
        public virtual ICollection<OpOperDetProd> OpOperDetProds { get; set; }
        public virtual ICollection<OrdenCompraLinea> OrdenCompraLineas { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<OrdenProduccion> OrdenProduccionBodegaMpNavigations { get; set; }
        public virtual ICollection<OrdenProduccion> OrdenProduccionBodegaPtNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo> OrdenTrabajos { get; set; }
        public virtual ICollection<PedidoLinea> PedidoLineas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<SpPronosticoDetalle> SpPronosticoDetalles { get; set; }
        public virtual ICollection<UsuarioBodega> UsuarioBodegas { get; set; }
    }
}
