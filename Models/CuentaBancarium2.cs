using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaBancarium2
    {
        public CuentaBancarium2()
        {
            CajaBanco2s = new HashSet<CajaBanco2>();
            Cheque2s = new HashSet<Cheque2>();
            ConceptoLiquidac2s = new HashSet<ConceptoLiquidac2>();
            Conciliacion2s = new HashSet<Conciliacion2>();
            DocumentosCc2s = new HashSet<DocumentosCc2>();
            DocumentosCp2ChequeCuentaNavigations = new HashSet<DocumentosCp2>();
            DocumentosCp2CuentaBancoNavigations = new HashSet<DocumentosCp2>();
            EmpleadoNomiNeto2s = new HashSet<EmpleadoNomiNeto2>();
            Liquidacion2s = new HashSet<Liquidacion2>();
            MovBanco2s = new HashSet<MovBanco2>();
            MovProcesado2s = new HashSet<MovProcesado2>();
            MovReportado2s = new HashSet<MovReportado2>();
            Nomina2s = new HashSet<Nomina2>();
            NominaBanco2s = new HashSet<NominaBanco2>();
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

        public virtual CentroCuentum2? Ct { get; set; }
        public virtual CentroCuentum2? Ct1 { get; set; }
        public virtual CentroCuentum2? Ct2 { get; set; }
        public virtual CentroCuentum2? Ct3 { get; set; }
        public virtual CentroCuentum2? Ct4 { get; set; }
        public virtual CentroCuentum2? Ct5 { get; set; }
        public virtual CentroCuentum2? Ct6 { get; set; }
        public virtual CentroCuentum2? Ct7 { get; set; }
        public virtual CentroCuentum2? Ct8 { get; set; }
        public virtual CentroCuentum2? CtNavigation { get; set; }
        public virtual EntidadFinanciera2 EntidadFinancieraNavigation { get; set; } = null!;
        public virtual Monedum2 MonedaNavigation { get; set; } = null!;
        public virtual TipoCuentum2? TipoCuentaNavigation { get; set; }
        public virtual Usuario2 UsuarioCreacionNavigation { get; set; } = null!;
        public virtual Usuario2? UsuarioModificNavigation { get; set; }
        public virtual ICollection<CajaBanco2> CajaBanco2s { get; set; }
        public virtual ICollection<Cheque2> Cheque2s { get; set; }
        public virtual ICollection<ConceptoLiquidac2> ConceptoLiquidac2s { get; set; }
        public virtual ICollection<Conciliacion2> Conciliacion2s { get; set; }
        public virtual ICollection<DocumentosCc2> DocumentosCc2s { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2ChequeCuentaNavigations { get; set; }
        public virtual ICollection<DocumentosCp2> DocumentosCp2CuentaBancoNavigations { get; set; }
        public virtual ICollection<EmpleadoNomiNeto2> EmpleadoNomiNeto2s { get; set; }
        public virtual ICollection<Liquidacion2> Liquidacion2s { get; set; }
        public virtual ICollection<MovBanco2> MovBanco2s { get; set; }
        public virtual ICollection<MovProcesado2> MovProcesado2s { get; set; }
        public virtual ICollection<MovReportado2> MovReportado2s { get; set; }
        public virtual ICollection<Nomina2> Nomina2s { get; set; }
        public virtual ICollection<NominaBanco2> NominaBanco2s { get; set; }
    }
}
