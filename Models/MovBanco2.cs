using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class MovBanco2
    {
        public MovBanco2()
        {
            DetTiposervicioCb2s = new HashSet<DetTiposervicioCb2>();
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
        public string? TipoCf { get; set; }
        public string? MetodoPago { get; set; }

        public virtual Conciliacion2? C { get; set; }
        public virtual Conciliacion2? CNavigation { get; set; }
        public virtual Impuesto2? CodImpuesto1Navigation { get; set; }
        public virtual Nit2? ContribuyenteNavigation { get; set; }
        public virtual CuentaBancarium2 CuentaBancoNavigation { get; set; } = null!;
        public virtual MovReportado2? DocAjusteNavigation { get; set; }
        public virtual MovReportado2? DocReportadoNavigation { get; set; }
        public virtual MetodoPago2? MetodoPagoNavigation { get; set; }
        public virtual Paquete2? PaqueteNavigation { get; set; }
        public virtual Proveedor2? ProveedorNavigation { get; set; }
        public virtual SubtipoDocCb2? SubtipoDocCb2 { get; set; }
        public virtual TipoAsiento2? TipoAsientoNavigation { get; set; }
        public virtual Usuario2? UsuarioAnuladoNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual TransferenciaCb2 TransferenciaCb2 { get; set; } = null!;
        public virtual ICollection<DetTiposervicioCb2> DetTiposervicioCb2s { get; set; }
    }
}
