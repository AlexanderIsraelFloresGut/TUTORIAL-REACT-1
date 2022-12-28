using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class GlobalesCp2
    {
        public DateTime FechaUltComprime { get; set; }
        public string LimpiarAplicacion { get; set; } = null!;
        public string DetalleObligat { get; set; } = null!;
        public string? ChqAPantalla { get; set; }
        public string PagoOtraMoneda { get; set; } = null!;
        public string DocProntoPago { get; set; } = null!;
        public string? UltimoCh { get; set; }
        public string? UltimoNc { get; set; }
        public string? UltimoOc { get; set; }
        public string? UltimoRet { get; set; }
        public short? VencPeriodo1 { get; set; }
        public short? VencPeriodo2 { get; set; }
        public short? VencPeriodo3 { get; set; }
        public short? VencPeriodo4 { get; set; }
        public short? AntPeriodo1 { get; set; }
        public short? AntPeriodo2 { get; set; }
        public short? AntPeriodo3 { get; set; }
        public short? AntPeriodo4 { get; set; }
        public string UsarRubros { get; set; } = null!;
        public string? Rubro1Nombre { get; set; }
        public string? Rubro2Nombre { get; set; }
        public string? ImpuestoXOmision { get; set; }
        public string AsientoNd { get; set; } = null!;
        public string AsientoFac { get; set; } = null!;
        public string AsientoInt { get; set; } = null!;
        public string AsientoOd { get; set; } = null!;
        public string AsientoChq { get; set; } = null!;
        public string AsientoTef { get; set; } = null!;
        public string AsientoLc { get; set; } = null!;
        public string AsientoNc { get; set; } = null!;
        public string AsientoOc { get; set; } = null!;
        public string? PaqueteCre { get; set; }
        public string? TipoAsientoCre { get; set; }
        public string? PaqueteDeb { get; set; }
        public string? TipoAsientoDeb { get; set; }
        public string AsientosCtaPais { get; set; } = null!;
        public string IntegracionConta { get; set; } = null!;
        public short ModAplicAsiento { get; set; }
        public string TipoContaOmision { get; set; } = null!;
        public string? UltimoContrarec { get; set; }
        public string NitDuplicado { get; set; } = null!;
        public string RefrescaAuto { get; set; } = null!;
        public string UsarRubrosProv { get; set; } = null!;
        public string? Rubro1ProvNombre { get; set; }
        public string? Rubro2ProvNombre { get; set; }
        public string? Rubro3ProvNombre { get; set; }
        public string? Rubro4ProvNombre { get; set; }
        public string? Rubro5ProvNombre { get; set; }
        public string Copiarnotasenasnt { get; set; } = null!;
        public string Asocobligcontfact { get; set; } = null!;
        public string UsarRubrosVal { get; set; } = null!;
        public string? NomRubro1Pro { get; set; }
        public string? NomRubro2Pro { get; set; }
        public string? NomRubro3Pro { get; set; }
        public string? NomRubro4Pro { get; set; }
        public string? NomRubro5Pro { get; set; }
        public string FormaCreacion { get; set; } = null!;
        public short? RubrosDiasRev { get; set; }
        public string UsaFechaCont { get; set; } = null!;
        public short? DiasContables { get; set; }
        public string? NumLimiteRet { get; set; }
        public DateTime FechaUltDifcamb { get; set; }
        public string? UltimoFac { get; set; }
        public string? UltimoInt { get; set; }
        public string? UltimoLc { get; set; }
        public string? UltimoNd { get; set; }
        public string? UltimoOd { get; set; }
        public string? NomRubro6Pro { get; set; }
        public string? NomRubro7Pro { get; set; }
        public string? NomRubro8Pro { get; set; }
        public string? NomRubro9Pro { get; set; }
        public string? NomRubro10Pro { get; set; }
        public string AsignarMismaEntidad { get; set; } = null!;
        public string? UltimoRed { get; set; }
        public string? IntegracionCr { get; set; }
        public string? PaqueteCr { get; set; }
        public string? PresupuestoCr { get; set; }
        public string? RequierePresup { get; set; }
        public string AsientoIntCorriente { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string AsientoDet { get; set; } = null!;
        public string AsientoPer { get; set; } = null!;
        public string AsientoRet { get; set; } = null!;
        public string AsientoRed { get; set; } = null!;

        public virtual Impuesto2? ImpuestoXOmisionNavigation { get; set; }
        public virtual Paquete2? PaqueteCreNavigation { get; set; }
        public virtual Paquete2? PaqueteDebNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoCreNavigation { get; set; }
        public virtual TipoAsiento2? TipoAsientoDebNavigation { get; set; }
    }
}
