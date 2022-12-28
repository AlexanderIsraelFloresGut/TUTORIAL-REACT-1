using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Bodega2
    {
        public Bodega2()
        {
            ArticuloCompra2s = new HashSet<ArticuloCompra2>();
            BodegaEncargado2s = new HashSet<BodegaEncargado2>();
            CostStdBatch2s = new HashSet<CostStdBatch2>();
            CostoStdDesgl2s = new HashSet<CostoStdDesgl2>();
            DespachoDetalle2s = new HashSet<DespachoDetalle2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            ExistenciaBodega2s = new HashSet<ExistenciaBodega2>();
            ExistenciaCierre2s = new HashSet<ExistenciaCierre2>();
            FacturaLinea2s = new HashSet<FacturaLinea2>();
            Localizacion2s = new HashSet<Localizacion2>();
            OpOperDetProd2s = new HashSet<OpOperDetProd2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            OrdenCompraLinea2s = new HashSet<OrdenCompraLinea2>();
            OrdenProduccion2BodegaMpNavigations = new HashSet<OrdenProduccion2>();
            OrdenProduccion2BodegaPtNavigations = new HashSet<OrdenProduccion2>();
            Pedido2s = new HashSet<Pedido2>();
            PedidoLinea2s = new HashSet<PedidoLinea2>();
            SpPronosticoDetalle2s = new HashSet<SpPronosticoDetalle2>();
            UsuarioBodega2s = new HashSet<UsuarioBodega2>();
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

        public virtual ConsecutivoCi2? ConsecTrasladosNavigation { get; set; }
        public virtual BodCargaManuf2 BodCargaManuf2 { get; set; } = null!;
        public virtual ICollection<ArticuloCompra2> ArticuloCompra2s { get; set; }
        public virtual ICollection<BodegaEncargado2> BodegaEncargado2s { get; set; }
        public virtual ICollection<CostStdBatch2> CostStdBatch2s { get; set; }
        public virtual ICollection<CostoStdDesgl2> CostoStdDesgl2s { get; set; }
        public virtual ICollection<DespachoDetalle2> DespachoDetalle2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<ExistenciaBodega2> ExistenciaBodega2s { get; set; }
        public virtual ICollection<ExistenciaCierre2> ExistenciaCierre2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2s { get; set; }
        public virtual ICollection<Localizacion2> Localizacion2s { get; set; }
        public virtual ICollection<OpOperDetProd2> OpOperDetProd2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<OrdenCompraLinea2> OrdenCompraLinea2s { get; set; }
        public virtual ICollection<OrdenProduccion2> OrdenProduccion2BodegaMpNavigations { get; set; }
        public virtual ICollection<OrdenProduccion2> OrdenProduccion2BodegaPtNavigations { get; set; }
        public virtual ICollection<Pedido2> Pedido2s { get; set; }
        public virtual ICollection<PedidoLinea2> PedidoLinea2s { get; set; }
        public virtual ICollection<SpPronosticoDetalle2> SpPronosticoDetalle2s { get; set; }
        public virtual ICollection<UsuarioBodega2> UsuarioBodega2s { get; set; }
    }
}
