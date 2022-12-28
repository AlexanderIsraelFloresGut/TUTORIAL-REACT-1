using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MovBanco
    {
        public MovBanco()
        {
            DetTiposervicioCbs = new HashSet<DetTiposervicioCb>();
        }

        public string CuentaBanco { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public decimal Numero { get; set; }
        public short? Subtipo { get; set; }
        public DateTime Fecha { get; set; }
        public string? PagaderoA { get; set; }
        public string Referencia { get; set; } = null!;
        public decimal Monto { get; set; }
        public int? ConcilAclaracion { get; set; }
        public string? Proveedor { get; set; }
        public string? Contribuyente { get; set; }
        public string? Detalle { get; set; }
        public string Confirmado { get; set; } = null!;
        public string? Origen { get; set; }
        public string? Asiento { get; set; }
        public string Anulado { get; set; } = null!;
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public decimal? MontoAnulado { get; set; }
        public string Estado { get; set; } = null!;
        public int? Conciliacion { get; set; }
        public string? Impreso { get; set; }
        public int? DocReportado { get; set; }
        public decimal? MontoReportado { get; set; }
        public string ClaseDif { get; set; } = null!;
        public string AclaradaDif { get; set; } = null!;
        public int? DocAjuste { get; set; }
        public string? TipoDocAjuste { get; set; }
        public decimal? NumeroDocAjuste { get; set; }
        public string ClaseDocumento { get; set; } = null!;
        public string ModoRegistro { get; set; } = null!;
        public string Liquidado { get; set; } = null!;
        public DateTime? FchHoraModific { get; set; }
        public string? UsuarioModific { get; set; }
        public decimal TipoCambioLocal { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public DateTime? FchHoraAnulado { get; set; }
        public string? UsuarioAnulado { get; set; }
        public string? ReferenciaAnulado { get; set; }
        public string Aprobado { get; set; } = null!;
        public string? UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string? TipoAsiento { get; set; }
        public string? Paquete { get; set; }
        public string DependienteGp { get; set; } = null!;
        public string? DocumentoFiscal { get; set; }
        public DateTime? FechaContable { get; set; }
        public string? CodImpuesto1 { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Imp1Nodes { get; set; }
        public string? DocumentoGlobal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string UCash { get; set; } = null!;
        public string? TipoCf { get; set; }
        public string? MetodoPago { get; set; }

        public virtual Conciliacion? C { get; set; }
        public virtual Conciliacion? CNavigation { get; set; }
        public virtual Impuesto? CodImpuesto1Navigation { get; set; }
        public virtual Nit? ContribuyenteNavigation { get; set; }
        public virtual CuentaBancarium CuentaBancoNavigation { get; set; } = null!;
        public virtual MovReportado? DocAjusteNavigation { get; set; }
        public virtual MovReportado? DocReportadoNavigation { get; set; }
        public virtual MetodoPago? MetodoPagoNavigation { get; set; }
        public virtual Paquete? PaqueteNavigation { get; set; }
        public virtual Proveedor? ProveedorNavigation { get; set; }
        public virtual SubtipoDocCb? SubtipoDocCb { get; set; }
        public virtual TipoAsiento? TipoAsientoNavigation { get; set; }
        public virtual Usuario2? UsuarioAnuladoNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual TransferenciaCb TransferenciaCb { get; set; } = null!;
        public virtual ICollection<DetTiposervicioCb> DetTiposervicioCbs { get; set; }
    }
}
