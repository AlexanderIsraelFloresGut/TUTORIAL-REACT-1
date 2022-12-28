using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Proveedor1
    {
        public Proveedor1()
        {
            ActivoDesmantelamiento1s = new HashSet<ActivoDesmantelamiento1>();
            Articulo1s = new HashSet<Articulo1>();
            ArticuloCompra1s = new HashSet<ArticuloCompra1>();
            ArticuloProveedor1s = new HashSet<ArticuloProveedor1>();
            AuxiliarCp1s = new HashSet<AuxiliarCp1>();
            Concepto1s = new HashSet<Concepto1>();
            Contrarecibo1s = new HashSet<Contrarecibo1>();
            Devolucion1s = new HashSet<Devolucion1>();
            DocumentoEmbarque1s = new HashSet<DocumentoEmbarque1>();
            DocumentosCp1s = new HashSet<DocumentosCp1>();
            Embarque1s = new HashSet<Embarque1>();
            Equipo1s = new HashSet<Equipo1>();
            LiquidacCompra1s = new HashSet<LiquidacCompra1>();
            Lote1s = new HashSet<Lote1>();
            MovBanco1s = new HashSet<MovBanco1>();
            OrdenCompra1s = new HashSet<OrdenCompra1>();
            PedidoSugerido1s = new HashSet<PedidoSugerido1>();
            PrecioArtProv1s = new HashSet<PrecioArtProv1>();
            ProvRetencion1s = new HashSet<ProvRetencion1>();
            ProvValoresCertif1s = new HashSet<ProvValoresCertif1>();
            ProveedorEntidad1s = new HashSet<ProveedorEntidad1>();
            RecepcionDetrac1s = new HashSet<RecepcionDetrac1>();
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
        public string? UUdf { get; set; }
        public string? UCcp { get; set; }
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
        public string? ImpuestoRenta { get; set; }
        public string RentaAsumida { get; set; } = null!;
        public string? UltNumEnvio { get; set; }
        public string? NumResCoactiva { get; set; }
        public string GrandesCompraSemt { get; set; } = null!;
        public string? TipoServicio { get; set; }
        public string PdbExportadores { get; set; } = null!;

        public virtual CategoriaProveed1 CategoriaProveedNavigation { get; set; } = null!;
        public virtual Impuesto1? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago1 CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit1 ContribuyenteNavigation { get; set; } = null!;
        public virtual ConvenioTributacion1? ConvenioNavigation { get; set; }
        public virtual DetalleDireccion1? DetalleDireccionNavigation { get; set; }
        public virtual ExoneracionOperacione1? ExoneracionOperNavigation { get; set; }
        public virtual Impuesto1? ImpuestoRentaNavigation { get; set; }
        public virtual ModeloRetencion1? ModeloRetencionNavigation { get; set; }
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Pai1 PaisNavigation { get; set; } = null!;
        public virtual TipoTarifaIva1? Tipo { get; set; }
        public virtual TipoImpuesto1? TipoImpuestoNavigation { get; set; }
        public virtual TipoServicio? TipoServicioNavigation { get; set; }
        public virtual TipoVinculacionEconomica1? TipoVinculacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Evalprov1 Evalprov1 { get; set; } = null!;
        public virtual ICollection<ActivoDesmantelamiento1> ActivoDesmantelamiento1s { get; set; }
        public virtual ICollection<Articulo1> Articulo1s { get; set; }
        public virtual ICollection<ArticuloCompra1> ArticuloCompra1s { get; set; }
        public virtual ICollection<ArticuloProveedor1> ArticuloProveedor1s { get; set; }
        public virtual ICollection<AuxiliarCp1> AuxiliarCp1s { get; set; }
        public virtual ICollection<Concepto1> Concepto1s { get; set; }
        public virtual ICollection<Contrarecibo1> Contrarecibo1s { get; set; }
        public virtual ICollection<Devolucion1> Devolucion1s { get; set; }
        public virtual ICollection<DocumentoEmbarque1> DocumentoEmbarque1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1s { get; set; }
        public virtual ICollection<Embarque1> Embarque1s { get; set; }
        public virtual ICollection<Equipo1> Equipo1s { get; set; }
        public virtual ICollection<LiquidacCompra1> LiquidacCompra1s { get; set; }
        public virtual ICollection<Lote1> Lote1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<OrdenCompra1> OrdenCompra1s { get; set; }
        public virtual ICollection<PedidoSugerido1> PedidoSugerido1s { get; set; }
        public virtual ICollection<PrecioArtProv1> PrecioArtProv1s { get; set; }
        public virtual ICollection<ProvRetencion1> ProvRetencion1s { get; set; }
        public virtual ICollection<ProvValoresCertif1> ProvValoresCertif1s { get; set; }
        public virtual ICollection<ProveedorEntidad1> ProveedorEntidad1s { get; set; }
        public virtual ICollection<RecepcionDetrac1> RecepcionDetrac1s { get; set; }
    }
}
