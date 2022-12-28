using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            ActivoDesmantelamientos = new HashSet<ActivoDesmantelamiento>();
            ArticuloCompras = new HashSet<ArticuloCompra>();
            ArticuloProveedors = new HashSet<ArticuloProveedor>();
            Articulos = new HashSet<Articulo>();
            AuxiliarCps = new HashSet<AuxiliarCp>();
            Conceptos = new HashSet<Concepto>();
            Contrarecibos = new HashSet<Contrarecibo>();
            Devolucions = new HashSet<Devolucion>();
            DocumentoEmbarques = new HashSet<DocumentoEmbarque>();
            DocumentosCps = new HashSet<DocumentosCp>();
            Embarques = new HashSet<Embarque>();
            Equipos = new HashSet<Equipo>();
            LiquidacCompras = new HashSet<LiquidacCompra>();
            Lotes = new HashSet<Lote>();
            MovBancos = new HashSet<MovBanco>();
            OrdenCompras = new HashSet<OrdenCompra>();
            PedidoSugeridos = new HashSet<PedidoSugerido>();
            PrecioArtProvs = new HashSet<PrecioArtProv>();
            ProvRetencions = new HashSet<ProvRetencion>();
            ProvValoresCertifs = new HashSet<ProvValoresCertif>();
            ProveedorEntidads = new HashSet<ProveedorEntidad>();
            RecepcionDetracs = new HashSet<RecepcionDetrac>();
        }

        public string Proveedor1 { get; set; } = null!;
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
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string Internaciones { get; set; } = null!;
        public string? UUdf { get; set; }
        public string UCcp { get; set; } = null!;
        public string? UBarco { get; set; }
        public string? UPropio { get; set; }
        public int? UConsecutivo { get; set; }
        public int? UAnio { get; set; }
        public string? UCapitan { get; set; }
        public string? UPorcentLogistica { get; set; }
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

        public virtual CategoriaProveed CategoriaProveedNavigation { get; set; } = null!;
        public virtual Impuesto? CodigoImpuestoNavigation { get; set; }
        public virtual CondicionPago CondicionPagoNavigation { get; set; } = null!;
        public virtual Nit ContribuyenteNavigation { get; set; } = null!;
        public virtual ConvenioTributacion? ConvenioNavigation { get; set; }
        public virtual DetalleDireccion? DetalleDireccionNavigation { get; set; }
        public virtual ExoneracionOperacione? ExoneracionOperNavigation { get; set; }
        public virtual ModeloRetencion? ModeloRetencionNavigation { get; set; }
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual Pai PaisNavigation { get; set; } = null!;
        public virtual TipoTarifaIva? Tipo { get; set; }
        public virtual TipoImpuesto? TipoImpuestoNavigation { get; set; }
        public virtual TipoVinculacionEconomica? TipoVinculacionNavigation { get; set; }
        public virtual Usuario2? UsuarioCreacionNavigation { get; set; }
        public virtual Usuario2? UsuarioUltModNavigation { get; set; }
        public virtual Evalprov Evalprov { get; set; } = null!;
        public virtual ICollection<ActivoDesmantelamiento> ActivoDesmantelamientos { get; set; }
        public virtual ICollection<ArticuloCompra> ArticuloCompras { get; set; }
        public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<AuxiliarCp> AuxiliarCps { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
        public virtual ICollection<Contrarecibo> Contrarecibos { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<DocumentoEmbarque> DocumentoEmbarques { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCps { get; set; }
        public virtual ICollection<Embarque> Embarques { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<LiquidacCompra> LiquidacCompras { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<PedidoSugerido> PedidoSugeridos { get; set; }
        public virtual ICollection<PrecioArtProv> PrecioArtProvs { get; set; }
        public virtual ICollection<ProvRetencion> ProvRetencions { get; set; }
        public virtual ICollection<ProvValoresCertif> ProvValoresCertifs { get; set; }
        public virtual ICollection<ProveedorEntidad> ProveedorEntidads { get; set; }
        public virtual ICollection<RecepcionDetrac> RecepcionDetracs { get; set; }
    }
}
