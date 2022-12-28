using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCc1
    {
        public string? UltNotaCredito { get; set; }
        public string? UltNotaDebito { get; set; }
        public string? UltInteresMora { get; set; }
        public string? UltReciboDinero { get; set; }
        public string? UltFactura { get; set; }
        public string? UltOtroCredito { get; set; }
        public string? UltOtroDebito { get; set; }
        public string? UltRetencion { get; set; }
        public DateTime FechaUltComprime { get; set; }
        public string LimpiarAplicacion { get; set; } = null!;
        public string IntroFacturas { get; set; } = null!;
        public string? TipoAsientoDeb { get; set; }
        public string? PaqueteDeb { get; set; }
        public string? TipoAsientoCre { get; set; }
        public string? PaqueteCre { get; set; }
        public short? VencPeriodo1 { get; set; }
        public short? VencPeriodo2 { get; set; }
        public short? VencPeriodo3 { get; set; }
        public short? VencPeriodo4 { get; set; }
        public short? AntPeriodo1 { get; set; }
        public short? AntPeriodo2 { get; set; }
        public short? AntPeriodo3 { get; set; }
        public short? AntPeriodo4 { get; set; }
        public string AsientoFac { get; set; } = null!;
        public string AsientoInt { get; set; } = null!;
        public string AsientoNd { get; set; } = null!;
        public string AsientoOd { get; set; } = null!;
        public string AsientoLc { get; set; } = null!;
        public string AsientoRec { get; set; } = null!;
        public string AsientoNc { get; set; } = null!;
        public string AsientoOc { get; set; } = null!;
        public string AsientoDep { get; set; } = null!;
        public string AsientoTef { get; set; } = null!;
        public string AsientosCtaPais { get; set; } = null!;
        public string TipoContaOmision { get; set; } = null!;
        public string IntegracionConta { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string NitDuplicado { get; set; } = null!;
        public string RefrescaAuto { get; set; } = null!;
        public string DocProntoPago { get; set; } = null!;
        public string DetalleObligat { get; set; } = null!;
        public string UsarRubros { get; set; } = null!;
        public string? Rubro1Nombre { get; set; }
        public string? Rubro2Nombre { get; set; }
        public string? ImpuestoXOmision { get; set; }
        public string UsarRubrosCli { get; set; } = null!;
        public string? Rubro1CliNombre { get; set; }
        public string? Rubro2CliNombre { get; set; }
        public string? Rubro3CliNombre { get; set; }
        public string? Rubro4CliNombre { get; set; }
        public string? Rubro5CliNombre { get; set; }
        public string Copiarnotasenasnt { get; set; } = null!;
        public string Asocobligcontfact { get; set; } = null!;
        public short? VencPeriodo5 { get; set; }
        public short? VencPeriodo6 { get; set; }
        public short? AntPeriodo5 { get; set; }
        public short? AntPeriodo6 { get; set; }
        public string AsociacionDeDocs { get; set; } = null!;
        public string? NomRubro1Cli { get; set; }
        public string? NomRubro2Cli { get; set; }
        public string? NomRubro3Cli { get; set; }
        public string? NomRubro4Cli { get; set; }
        public string? NomRubro5Cli { get; set; }
        public string UsarRubrosVal { get; set; } = null!;
        public string FormaCreacion { get; set; } = null!;
        public short? RubrosDiasRev { get; set; }
        public string AsientoIntc { get; set; } = null!;
        public string? UltInteresCte { get; set; }
        public DateTime FechaUltDifcamb { get; set; }
        public string? UltLetracambio { get; set; }
        public string? UltDeposito { get; set; }
        public string? UltTef { get; set; }
        public string? UltRetdebito { get; set; }
        public string? NomRubro11Cli { get; set; }
        public string? NomRubro12Cli { get; set; }
        public string? NomRubro13Cli { get; set; }
        public string? NomRubro14Cli { get; set; }
        public string? NomRubro15Cli { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? AsientoDet { get; set; }
        public string? AsientoPer { get; set; }
        public string? AsientoRet { get; set; }
        public string? AsientoRed { get; set; }
        public short? SubtipoProntoPago { get; set; }
        public string? ConsecutivoGl { get; set; }
        public string? ConsecutivoDe { get; set; }
        public string? UsaImpFiscal { get; set; }

        public virtual Impuesto1? ImpuestoXOmisionNavigation { get; set; }
        public virtual Paquete1? PaqueteCreNavigation { get; set; }
        public virtual Paquete1? PaqueteDebNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoCreNavigation { get; set; }
        public virtual TipoAsiento1? TipoAsientoDebNavigation { get; set; }
    }
}
