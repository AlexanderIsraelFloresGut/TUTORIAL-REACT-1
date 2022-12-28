using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Bodega1
    {
        public Bodega1()
        {
            ArticuloCompra1s = new HashSet<ArticuloCompra1>();
            BodegaEncargado1s = new HashSet<BodegaEncargado1>();
            CostStdBatch1s = new HashSet<CostStdBatch1>();
            CostoStdDesgl1s = new HashSet<CostoStdDesgl1>();
            DespachoDetalle1s = new HashSet<DespachoDetalle1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            ExistenciaBodega1s = new HashSet<ExistenciaBodega1>();
            ExistenciaCierre1s = new HashSet<ExistenciaCierre1>();
            FacturaLinea1s = new HashSet<FacturaLinea1>();
            Localizacion1s = new HashSet<Localizacion1>();
            OpOperDetProd1s = new HashSet<OpOperDetProd1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            OrdenCompraLinea1s = new HashSet<OrdenCompraLinea1>();
            OrdenProduccion1BodegaMpNavigations = new HashSet<OrdenProduccion1>();
            OrdenProduccion1BodegaPtNavigations = new HashSet<OrdenProduccion1>();
            OrdenTrabajo1s = new HashSet<OrdenTrabajo1>();
            Pedido1s = new HashSet<Pedido1>();
            PedidoLinea1s = new HashSet<PedidoLinea1>();
            SpPronosticoDetalle1s = new HashSet<SpPronosticoDetalle1>();
            UsuarioBodega1s = new HashSet<UsuarioBodega1>();
        }

        public string Bodega { get; set; } = null!;
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
        public string NoStockNegativo { get; set; } = null!;

        public virtual ConsecutivoCi1? ConsecTrasladosNavigation { get; set; }
        public virtual BodCargaManuf1 BodCargaManuf1 { get; set; } = null!;
        public virtual ICollection<ArticuloCompra1> ArticuloCompra1s { get; set; }
        public virtual ICollection<BodegaEncargado1> BodegaEncargado1s { get; set; }
        public virtual ICollection<CostStdBatch1> CostStdBatch1s { get; set; }
        public virtual ICollection<CostoStdDesgl1> CostoStdDesgl1s { get; set; }
        public virtual ICollection<DespachoDetalle1> DespachoDetalle1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<ExistenciaBodega1> ExistenciaBodega1s { get; set; }
        public virtual ICollection<ExistenciaCierre1> ExistenciaCierre1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1s { get; set; }
        public virtual ICollection<Localizacion1> Localizacion1s { get; set; }
        public virtual ICollection<OpOperDetProd1> OpOperDetProd1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<OrdenCompraLinea1> OrdenCompraLinea1s { get; set; }
        public virtual ICollection<OrdenProduccion1> OrdenProduccion1BodegaMpNavigations { get; set; }
        public virtual ICollection<OrdenProduccion1> OrdenProduccion1BodegaPtNavigations { get; set; }
        public virtual ICollection<OrdenTrabajo1> OrdenTrabajo1s { get; set; }
        public virtual ICollection<Pedido1> Pedido1s { get; set; }
        public virtual ICollection<PedidoLinea1> PedidoLinea1s { get; set; }
        public virtual ICollection<SpPronosticoDetalle1> SpPronosticoDetalle1s { get; set; }
        public virtual ICollection<UsuarioBodega1> UsuarioBodega1s { get; set; }
    }
}
