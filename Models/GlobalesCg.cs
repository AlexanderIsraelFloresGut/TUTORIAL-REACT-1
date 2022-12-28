using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCg
    {
        public string? CtaPerdDifcamdol { get; set; }
        public string? CtaPerdDifcamloc { get; set; }
        public string? TipAsntCierreAn { get; set; }
        public string Patron { get; set; } = null!;
        public string? CtrDifcambiolocal { get; set; }
        public string? CtaDifcambiolocal { get; set; }
        public string? CtrDifcambiodolar { get; set; }
        public string? CtaDifcambiodolar { get; set; }
        public DateTime FechaDifcamFisc { get; set; }
        public DateTime FechaDifcamCorp { get; set; }
        public DateTime FechaCierreFisc { get; set; }
        public DateTime FechaCierreCorp { get; set; }
        public short MesCierreFiscal { get; set; }
        public short MesCierreCorp { get; set; }
        public string UltimoAsiento { get; set; } = null!;
        public string NumAsientoGlobal { get; set; } = null!;
        public string NombreAsiento { get; set; } = null!;
        public short CantDecimales { get; set; }
        public string TruncarConversion { get; set; } = null!;
        public string? CtrCierre { get; set; }
        public string? CtaCierre { get; set; }
        public string UsaCifraControl { get; set; } = null!;
        public string AjusAnFiscPend { get; set; } = null!;
        public string AjusAnCorpPend { get; set; } = null!;
        public string PermiteMovRojo { get; set; } = null!;
        public string AuxReverMovRojo { get; set; } = null!;
        public string UsarNits { get; set; } = null!;
        public string? CtrPerdDifcamloc { get; set; }
        public string? CtrPerdDifcamdol { get; set; }
        public string NitDefault { get; set; } = null!;
        public string? NombreContaFiscal { get; set; }
        public string? IntegracionCr { get; set; }
        public string? RequierePresup { get; set; }
        public string? PaqueteCr { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? NombreContaCorp { get; set; }
        public string? CtrDifcamlocUtiReali { get; set; }
        public string? CtaDifcamlocUtiReali { get; set; }
        public string? CtrDifcamdolUtiReali { get; set; }
        public string? CtaDifcamdolUtiReali { get; set; }
        public string? CtrDifcamlocPerReali { get; set; }
        public string? CtaDifcamlocPerReali { get; set; }
        public string? CtrDifcamdolPerReali { get; set; }
        public string? CtaDifcamdolPerReali { get; set; }
        public string DobleControl { get; set; } = null!;
        public string PNitsInactivos { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string UsaCuentasEspbalanceo { get; set; } = null!;
        public string? CtrUtlLocal { get; set; }
        public string? CtaUtlLocal { get; set; }
        public string? CtrUtlDolar { get; set; }
        public string? CtaUtlDolar { get; set; }
        public string? CtrPerdLocal { get; set; }
        public string? CtaPerdLocal { get; set; }
        public string? CtrPerdDolar { get; set; }
        public string? CtaPerdDolar { get; set; }
        public string NitCuentaContable { get; set; } = null!;

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual CuentaContable? CtaCierreNavigation { get; set; }
        public virtual CentroCosto? CtrCierreNavigation { get; set; }
        public virtual TipoAsiento? TipAsntCierreAnNavigation { get; set; }
    }
}
