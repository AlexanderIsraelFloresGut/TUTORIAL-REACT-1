using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloCuentum
    {
        public ArticuloCuentum()
        {
            Articulos = new HashSet<Articulo>();
        }

        public string ArticuloCuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? CtrInventario { get; set; }
        public string? CtaInventario { get; set; }
        public string? CtrVentasLoc { get; set; }
        public string? CtaVentasLoc { get; set; }
        public string? CtrVentasExp { get; set; }
        public string? CtaVentasExp { get; set; }
        public string? CtrCompraLoc { get; set; }
        public string? CtaCompraLoc { get; set; }
        public string? CtrCompraImp { get; set; }
        public string? CtaCompraImp { get; set; }
        public string? CtrDescVentaLoc { get; set; }
        public string? CtaDescVentaLoc { get; set; }
        public string? CtrDescVentaExp { get; set; }
        public string? CtaDescVentaExp { get; set; }
        public string? CtrCostVentaLoc { get; set; }
        public string? CtaCostVentaLoc { get; set; }
        public string? CtrCostVentaExp { get; set; }
        public string? CtaCostVentaExp { get; set; }
        public string? CtrComsVentaLoc { get; set; }
        public string? CtaComsVentaLoc { get; set; }
        public string? CtrComsVentaExp { get; set; }
        public string? CtaComsVentaExp { get; set; }
        public string? CtrComsCobroLoc { get; set; }
        public string? CtaComsCobroLoc { get; set; }
        public string? CtrComsCobroExp { get; set; }
        public string? CtaComsCobroExp { get; set; }
        public string? CtrDescLineaLoc { get; set; }
        public string? CtaDescLineaLoc { get; set; }
        public string? CtrDescLineaExp { get; set; }
        public string? CtaDescLineaExp { get; set; }
        public string? CtrCostDescLoc { get; set; }
        public string? CtaCostDescLoc { get; set; }
        public string? CtrCostDescExp { get; set; }
        public string? CtaCostDescExp { get; set; }
        public string? CtrSobrInventfis { get; set; }
        public string? CtaSobrInventfis { get; set; }
        public string? CtrFaltInventfis { get; set; }
        public string? CtaFaltInventfis { get; set; }
        public string? CtrVariaCosto { get; set; }
        public string? CtaVariaCosto { get; set; }
        public string? CtrVencimiento { get; set; }
        public string? CtaVencimiento { get; set; }
        public string? CtrSobranteRemis { get; set; }
        public string? CtaSobranteRemis { get; set; }
        public string? CtrFaltanteRemis { get; set; }
        public string? CtaFaltanteRemis { get; set; }
        public string? CtrInvRemitido { get; set; }
        public string? CtaInvRemitido { get; set; }
        public string? CtrMatProceso { get; set; }
        public string? CtaMatProceso { get; set; }
        public string? CtrConsNormal { get; set; }
        public string? CtaConsNormal { get; set; }
        public string? CtrConsRetrabajo { get; set; }
        public string? CtaConsRetrabajo { get; set; }
        public string? CtrConsGasto { get; set; }
        public string? CtaConsGasto { get; set; }
        public string? CtrConsDesperdic { get; set; }
        public string? CtaConsDesperdic { get; set; }
        public string? CtrDescBonifLoc { get; set; }
        public string? CtaDescBonifLoc { get; set; }
        public string? CtrDescBonifExp { get; set; }
        public string? CtaDescBonifExp { get; set; }
        public string? CtrDevVentasLoc { get; set; }
        public string? CtaDevVentasLoc { get; set; }
        public string? CtrDevVentasExp { get; set; }
        public string? CtaDevVentasExp { get; set; }
        public string? CtrCtoRetAsum { get; set; }
        public string? CtaCtbRetAsum { get; set; }
        public string? CtrCtoAju { get; set; }
        public string? CtaCtbAju { get; set; }
        public string? CtrCtoAjuCmv { get; set; }
        public string? CtaCtbAjuCmv { get; set; }
        public string? CtrCtoCpgar { get; set; }
        public string? CtaCtbCpgar { get; set; }
        public string? CtrCtoPugar { get; set; }
        public string? CtaCtbPugar { get; set; }
        public string? CtrCtoIngDevoluc { get; set; }
        public string? CtaCtbIngDevoluc { get; set; }
        public string? CtrCtoPerdDevoluc { get; set; }
        public string? CtaCtbPerdDevoluc { get; set; }
        public string? CtaMatAplicados { get; set; }
        public string? CtrMatAplicados { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? CtrVentasExenLoc { get; set; }
        public string? CtaVentasExenLoc { get; set; }
        public string? CtrVentasExenExp { get; set; }
        public string? CtaVentasExenExp { get; set; }
        public string? CtrCompraMercLoc { get; set; }
        public string? CtaCompraMercLoc { get; set; }
        public string? CtrVariacExistLoc { get; set; }
        public string? CtaVariacExistLoc { get; set; }
        public string? CtrCompraMercExt { get; set; }
        public string? CtaCompraMercExt { get; set; }
        public string? CtrVariacExistExt { get; set; }
        public string? CtaVariacExistExt { get; set; }

        public virtual CentroCuentum? Ct { get; set; }
        public virtual CentroCuentum? Ct1 { get; set; }
        public virtual CentroCuentum? Ct10 { get; set; }
        public virtual CentroCuentum? Ct11 { get; set; }
        public virtual CentroCuentum? Ct12 { get; set; }
        public virtual CentroCuentum? Ct13 { get; set; }
        public virtual CentroCuentum? Ct14 { get; set; }
        public virtual CentroCuentum? Ct15 { get; set; }
        public virtual CentroCuentum? Ct16 { get; set; }
        public virtual CentroCuentum? Ct17 { get; set; }
        public virtual CentroCuentum? Ct18 { get; set; }
        public virtual CentroCuentum? Ct19 { get; set; }
        public virtual CentroCuentum? Ct2 { get; set; }
        public virtual CentroCuentum? Ct20 { get; set; }
        public virtual CentroCuentum? Ct21 { get; set; }
        public virtual CentroCuentum? Ct22 { get; set; }
        public virtual CentroCuentum? Ct23 { get; set; }
        public virtual CentroCuentum? Ct24 { get; set; }
        public virtual CentroCuentum? Ct25 { get; set; }
        public virtual CentroCuentum? Ct26 { get; set; }
        public virtual CentroCuentum? Ct27 { get; set; }
        public virtual CentroCuentum? Ct28 { get; set; }
        public virtual CentroCuentum? Ct29 { get; set; }
        public virtual CentroCuentum? Ct3 { get; set; }
        public virtual CentroCuentum? Ct30 { get; set; }
        public virtual CentroCuentum? Ct31 { get; set; }
        public virtual CentroCuentum? Ct32 { get; set; }
        public virtual CentroCuentum? Ct33 { get; set; }
        public virtual CentroCuentum? Ct34 { get; set; }
        public virtual CentroCuentum? Ct35 { get; set; }
        public virtual CentroCuentum? Ct36 { get; set; }
        public virtual CentroCuentum? Ct37 { get; set; }
        public virtual CentroCuentum? Ct38 { get; set; }
        public virtual CentroCuentum? Ct39 { get; set; }
        public virtual CentroCuentum? Ct4 { get; set; }
        public virtual CentroCuentum? Ct40 { get; set; }
        public virtual CentroCuentum? Ct5 { get; set; }
        public virtual CentroCuentum? Ct6 { get; set; }
        public virtual CentroCuentum? Ct7 { get; set; }
        public virtual CentroCuentum? Ct8 { get; set; }
        public virtual CentroCuentum? Ct9 { get; set; }
        public virtual CentroCuentum? CtNavigation { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
