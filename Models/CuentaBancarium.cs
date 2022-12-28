using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaBancarium
    {
        public CuentaBancarium()
        {
            CajaBancos = new HashSet<CajaBanco>();
            Cheques = new HashSet<Cheque>();
            ConceptoLiquidacs = new HashSet<ConceptoLiquidac>();
            Conciliacions = new HashSet<Conciliacion>();
            DocumentosCcs = new HashSet<DocumentosCc>();
            DocumentosCpChequeCuentaNavigations = new HashSet<DocumentosCp>();
            DocumentosCpCuentaBancoNavigations = new HashSet<DocumentosCp>();
            EmpleadoNomiNetos = new HashSet<EmpleadoNomiNeto>();
            Liquidacions = new HashSet<Liquidacion>();
            MovBancos = new HashSet<MovBanco>();
            MovProcesados = new HashSet<MovProcesado>();
            MovReportados = new HashSet<MovReportado>();
            NominaBancos = new HashSet<NominaBanco>();
            Nominas = new HashSet<Nomina>();
        }

        public string CuentaBanco { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string EntidadFinanciera { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono1 { get; set; } = null!;
        public string Telefono2 { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string Formato { get; set; } = null!;
        public DateTime FechaUltMov { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoBancos { get; set; }
        public decimal PosicionDeCaja { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal TipoCambioLocal { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public string Activa { get; set; } = null!;
        public decimal UltimoDeposito { get; set; }
        public decimal UltimaTefcr { get; set; }
        public decimal LimiteSobregiro { get; set; }
        public string? CtrContable { get; set; }
        public string? CtaContable { get; set; }
        public string? CtrCierreDeb { get; set; }
        public string? CtaCierreDeb { get; set; }
        public string? CtrCierreCred { get; set; }
        public string? CtaCierreCred { get; set; }
        public decimal UltimaNotacr { get; set; }
        public decimal? UltimoCheque { get; set; }
        public decimal UltimoOtrocr { get; set; }
        public decimal? UltimaTefdb { get; set; }
        public decimal UltimaNotadb { get; set; }
        public decimal UltimoOtrodb { get; set; }
        public int? UltimaConcil { get; set; }
        public string ModoConciliar { get; set; } = null!;
        public string IdiomaMonLetras { get; set; } = null!;
        public string? TipoCredAjuste { get; set; }
        public short? SubtipoCredAjust { get; set; }
        public string? TipoDebAjuste { get; set; }
        public short? SubtipoDebAjust { get; set; }
        public string PermiteSobregiro { get; set; } = null!;
        public string? CtaAjusteCred { get; set; }
        public DateTime FchHoraCreacion { get; set; }
        public string UsuarioCreacion { get; set; } = null!;
        public string? CtrAjusteDeb { get; set; }
        public string? CtrGastoTransf { get; set; }
        public string? CtaAjusteDeb { get; set; }
        public string? CtaGastoTransf { get; set; }
        public string? CtrLiquidarCred { get; set; }
        public string? CtaLiquidarCred { get; set; }
        public string? CtrLiquidarDeb { get; set; }
        public string? CtaLiquidarDeb { get; set; }
        public string? CtrAjusteCred { get; set; }
        public DateTime? FchHoraModific { get; set; }
        public string? UsuarioModific { get; set; }
        public string PermiteTransfIc { get; set; } = null!;
        public string? CtaTransfIc { get; set; }
        public string? CtrTransfIc { get; set; }
        public string? Rubro1Ctabanco { get; set; }
        public string? Rubro2Ctabanco { get; set; }
        public string? Rubro3Ctabanco { get; set; }
        public string? Rubro4Ctabanco { get; set; }
        public string? Rubro5Ctabanco { get; set; }
        public string? Rubro6Ctabanco { get; set; }
        public string? Rubro7Ctabanco { get; set; }
        public string? Rubro8Ctabanco { get; set; }
        public string? Rubro9Ctabanco { get; set; }
        public string? Rubro10Ctabanco { get; set; }
        public string? ConseCheque { get; set; }
        public string? ConseTef { get; set; }
        public string? TipoCuenta { get; set; }
        public string? CtrDocGp { get; set; }
        public string? CtaDocGp { get; set; }
        public decimal SaldoTrans { get; set; }
        public decimal SaldoTransLocal { get; set; }
        public decimal SaldoTransDolar { get; set; }
        public string PermiteDocGp { get; set; } = null!;
        public string ParticipaFlujocaja { get; set; } = null!;
        public string? CtaElectronica { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? Ct7 { get; set; }
        public virtual CentroCuentum? Ct8 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual EntidadFinanciera EntidadFinancieraNavigation { get; set; } = null!;
        public virtual Monedum MonedaNavigation { get; set; } = null!;
        public virtual TipoCuentum? TipoCuentaNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual ICollection<CajaBanco> CajaBancos { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<ConceptoLiquidac> ConceptoLiquidacs { get; set; }
        public virtual ICollection<Conciliacion> Conciliacions { get; set; }
        public virtual ICollection<DocumentosCc> DocumentosCcs { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCpChequeCuentaNavigations { get; set; }
        public virtual ICollection<DocumentosCp> DocumentosCpCuentaBancoNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto> EmpleadoNomiNetos { get; set; }
        public virtual ICollection<Liquidacion> Liquidacions { get; set; }
        public virtual ICollection<MovBanco> MovBancos { get; set; }
        public virtual ICollection<MovProcesado> MovProcesados { get; set; }
        public virtual ICollection<MovReportado> MovReportados { get; set; }
        public virtual ICollection<NominaBanco> NominaBancos { get; set; }
        public virtual ICollection<Nomina> Nominas { get; set; }
    }
}
