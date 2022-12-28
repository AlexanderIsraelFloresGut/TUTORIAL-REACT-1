using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Proveedor2
    {
        public Proveedor2()
        {
            ActivoDesmantelamiento2s = new HashSet<ActivoDesmantelamiento2>();
            Articulo2s = new HashSet<Articulo2>();
            ArticuloCompra2s = new HashSet<ArticuloCompra2>();
            ArticuloProveedor2s = new HashSet<ArticuloProveedor2>();
            AuxiliarCp2s = new HashSet<AuxiliarCp2>();
            Concepto2s = new HashSet<Concepto2>();
            Contrarecibo2s = new HashSet<Contrarecibo2>();
            Devolucion2s = new HashSet<Devolucion2>();
            DocumentoEmbarque2s = new HashSet<DocumentoEmbarque2>();
            DocumentosCp2s = new HashSet<DocumentosCp2>();
            Embarque2s = new HashSet<Embarque2>();
            LiquidacCompra2s = new HashSet<LiquidacCompra2>();
            Lote2s = new HashSet<Lote2>();
            MovBanco2s = new HashSet<MovBanco2>();
            OrdenCompra2s = new HashSet<OrdenCompra2>();
            PedidoSugerido2s = new HashSet<PedidoSugerido2>();
            PrecioArtProv2s = new HashSet<PrecioArtProv2>();
            ProvRetencion2s = new HashSet<ProvRetencion2>();
            ProvValoresCertif2s = new HashSet<ProvValoresCertif2>();
            ProveedorEntidad2s = new HashSet<ProveedorEntidad2>();
            RecepcionDetrac2s = new HashSet<RecepcionDetrac2>();
        }

        public string Proveedor { get; set; } = null!;
        public int? DetalleDireccion { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Alias { get; set; }
        public string Contacto { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? EMail { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaUltMov { get; set; }
        public string Telefono1 { get; set; } = null!;
        public string Telefono2 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public decimal OrdenMinima { get; set; }
        public decimal Descuento { get; set; }
        public decimal? TasaInteresMora { get; set; }
        public string Local { get; set; } = null!;
        public string Congelado { get; set; } = null!;
        public string Contribuyente { get; set; } = null!;
        public string CondicionPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string CategoriaProveed { get; set; } = null!;
        public string Multimoneda { get; set; } = null!;
        public decimal Saldo { get; set; }
        public decimal SaldoLocal { get; set; }
        public decimal SaldoDolar { get; set; }
        public string? Notas { get; set; }
        public string? Rubro1Prov { get; set; }
        public string? Rubro2Prov { get; set; }
        public string? Rubro3Prov { get; set; }
        public string? Rubro4Prov { get; set; }
        public string? Rubro5Prov { get; set; }
        public string? Rubro1Proveedor { get; set; }
        public string? Rubro2Proveedor { get; set; }
        public string? Rubro3Proveedor { get; set; }
        public string? Rubro4Proveedor { get; set; }
        public string? Rubro5Proveedor { get; set; }
        public string? Gln { get; set; }
        public string? Ubicacion { get; set; }
        public string Activo { get; set; } = null!;
        public string? TipoContribuyente { get; set; }
        public string? Rubro6Proveedor { get; set; }
        public string? Rubro7Proveedor { get; set; }
        public string? Rubro8Proveedor { get; set; }
        public string? Rubro9Proveedor { get; set; }
        public string? Rubro10Proveedor { get; set; }
        public string? ModeloRetencion { get; set; }
        public string? CodigoImpuesto { get; set; }
        public string? DivisionGeografica1 { get; set; }
        public string? DivisionGeografica2 { get; set; }
        public string Autoretenedor { get; set; } = null!;
        public string? RegimenTrib { get; set; }
        public decimal SaldoTrans { get; set; }
        public decimal SaldoTransLocal { get; set; }
        public decimal SaldoTransDolar { get; set; }
        public string PermiteDocGp { get; set; } = null!;
        public string ParticipaFlujocaja { get; set; } = null!;
        public string? Curp { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string? UsuarioUltMod { get; set; }
        public DateTime? FchHoraUltMod { get; set; }
        public string Impuesto1Incluido { get; set; } = null!;
        public string? XsltPersonalizado { get; set; }
        public string? Ubicaciondocelectronico { get; set; }
        public string? EmailDocElectronico { get; set; }
        public string? EmailDocElectronicoCopia { get; set; }
        public string AceptaDocElectronico { get; set; } = null!;
        public string Internaciones { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoTarifa { get; set; }
        public decimal? PorcTarifa { get; set; }
        public string? TipificacionProveedor { get; set; }
        public string? DivisionGeografica3 { get; set; }
        public string? DivisionGeografica4 { get; set; }
        public string? ItemHaciendaCompra { get; set; }
        public string? TipoCf { get; set; }
        public string UsaPlame { get; set; } = null!;
        public decimal? ImpCategoria { get; set; }
        public string SistemaPensiones { get; set; } = null!;
        public decimal? ImpNacional { get; set; }
        public decimal? ImpPrivado { get; set; }
        public string Domiciliado { get; set; } = null!;
        public string? Convenio { get; set; }
        public string? NumIdentNoDomic { get; set; }
        public string? NumIdentFiscBenef { get; set; }
        public string? TipoVinculacion { get; set; }
        public decimal? TasaRetencion { get; set; }
        public string? ExoneracionOper { get; set; }
        public string BuenContribuyente { get; set; } = null!;
        public string AgenteRetencion { get; set; } = null!;

        public virtual CategoriaProveed2 CategoriaProveedNavigation { get; set; } = null!;
        public virtual Impuesto2? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago2 CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit2 ContribuyenteNavigation { get; set; } = null!;
        public virtual ConvenioTributacion2? ConvenioNavigation { get; set; }
        public virtual DetalleDireccion2? DetalleDireccionNavigation { get; set; }
        public virtual ExoneracionOperacione2? ExoneracionOperNavigation { get; set; }
        public virtual ModeloRetencion2? ModeloRetencionNavigation { get; set; }
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual Pai2 PaisNavigation { get; set; } = null!;
        public virtual TipoTarifaIva2? Tipo { get; set; }
        public virtual TipoImpuesto2? TipoImpuestoNavigation { get; set; }
        public virtual TipoVinculacionEconomica2? TipoVinculacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Evalprov2 Evalprov2 { get; set; } = null!;
        public virtual ICollection<ActivoDesmantelamiento2> ActivoDesmantelamiento2s { get; set; }
        public virtual ICollection<Articulo2> Articulo2s { get; set; }
        public virtual ICollection<ArticuloCompra2> ArticuloCompra2s { get; set; }
        public virtual ICollection<ArticuloProveedor2> ArticuloProveedor2s { get; set; }
        public virtual ICollection<AuxiliarCp2> AuxiliarCp2s { get; set; }
        public virtual ICollection<Concepto2> Concepto2s { get; set; }
        public virtual ICollection<Contrarecibo2> Contrarecibo2s { get; set; }
        public virtual ICollection<Devolucion2> Devolucion2s { get; set; }
        public virtual ICollection<DocumentoEmbarque2> DocumentoEmbarque2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2s { get; set; }
        public virtual ICollection<Embarque2> Embarque2s { get; set; }
        public virtual ICollection<LiquidacCompra2> LiquidacCompra2s { get; set; }
        public virtual ICollection<Lote2> Lote2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<OrdenCompra2> OrdenCompra2s { get; set; }
        public virtual ICollection<PedidoSugerido2> PedidoSugerido2s { get; set; }
        public virtual ICollection<PrecioArtProv2> PrecioArtProv2s { get; set; }
        public virtual ICollection<ProvRetencion2> ProvRetencion2s { get; set; }
        public virtual ICollection<ProvValoresCertif2> ProvValoresCertif2s { get; set; }
        public virtual ICollection<ProveedorEntidad2> ProveedorEntidad2s { get; set; }
        public virtual ICollection<RecepcionDetrac2> RecepcionDetrac2s { get; set; }
    }
}
