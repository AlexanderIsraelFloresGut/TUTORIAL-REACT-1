using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaBancarium1
    {
        public CuentaBancarium1()
        {
            CajaBanco1s = new HashSet<CajaBanco1>();
            Cheque1s = new HashSet<Cheque1>();
            ConceptoLiquidac1s = new HashSet<ConceptoLiquidac1>();
            Conciliacion1s = new HashSet<Conciliacion1>();
            DocumentosCc1s = new HashSet<DocumentosCc1>();
            DocumentosCp1ChequeCuentaNavigations = new HashSet<DocumentosCp1>();
            DocumentosCp1CuentaBancoNavigations = new HashSet<DocumentosCp1>();
            EmpleadoNomiNeto1s = new HashSet<EmpleadoNomiNeto1>();
            Liquidacion1s = new HashSet<Liquidacion1>();
            MovBanco1s = new HashSet<MovBanco1>();
            MovProcesado1s = new HashSet<MovProcesado1>();
            MovReportado1s = new HashSet<MovReportado1>();
            Nomina1s = new HashSet<Nomina1>();
            NominaBanco1s = new HashSet<NominaBanco1>();
            Vale1s = new HashSet<Vale1>();
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
        public string? CtrPagoNoDom { get; set; }
        public string? CtaPagoNoDom { get; set; }

        public virtual CentroCuentum1? Ct { get; set; }
        public virtual CentroCuentum1? Ct1 { get; set; }
        public virtual CentroCuentum1? Ct2 { get; set; }
        public virtual CentroCuentum1? Ct3 { get; set; }
        public virtual CentroCuentum1? Ct4 { get; set; }
        public virtual CentroCuentum1? Ct5 { get; set; }
        public virtual CentroCuentum1? Ct6 { get; set; }
        public virtual CentroCuentum1? Ct7 { get; set; }
        public virtual CentroCuentum1? Ct8 { get; set; }
        public virtual CentroCuentum1? CtNavigation { get; set; }
        public virtual EntidadFinanciera1 EntidadFinancieraNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual TipoCuentum1? TipoCuentaNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual ICollection<CajaBanco1> CajaBanco1s { get; set; }
        public virtual ICollection<Cheque1> Cheque1s { get; set; }
        public virtual ICollection<ConceptoLiquidac1> ConceptoLiquidac1s { get; set; }
        public virtual ICollection<Conciliacion1> Conciliacion1s { get; set; }
        public virtual ICollection<DocumentosCc1> DocumentosCc1s { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1ChequeCuentaNavigations { get; set; }
        public virtual ICollection<DocumentosCp1> DocumentosCp1CuentaBancoNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto1> EmpleadoNomiNeto1s { get; set; }
        public virtual ICollection<Liquidacion1> Liquidacion1s { get; set; }
        public virtual ICollection<MovBanco1> MovBanco1s { get; set; }
        public virtual ICollection<MovProcesado1> MovProcesado1s { get; set; }
        public virtual ICollection<MovReportado1> MovReportado1s { get; set; }
        public virtual ICollection<Nomina1> Nomina1s { get; set; }
        public virtual ICollection<NominaBanco1> NominaBanco1s { get; set; }
        public virtual ICollection<Vale1> Vale1s { get; set; }
    }
}
