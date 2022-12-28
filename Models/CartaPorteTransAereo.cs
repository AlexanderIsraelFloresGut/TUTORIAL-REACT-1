using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteTransAereo
    {
        public string Documento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? PermSct { get; set; }
        public string? NumPermisoSct { get; set; }
        public string? MatriculaAeronave { get; set; }
        public string? NombreAseg { get; set; }
        public string? NumPolizaseguro { get; set; }
        public string? NumeroGuia { get; set; }
        public string? LugarContrato { get; set; }
        public string? RfcTransportista { get; set; }
        public string? CodigoTransportista { get; set; }
        public string? NumRegidtribtranspor { get; set; }
        public string? ResidenciaFiscalTranspor { get; set; }
        public string? NombreTransportista { get; set; }
        public string? RfcEmbarcador { get; set; }
        public string? NumRegidtribembarc { get; set; }
        public string? ResidenciaFiscalEmbarc { get; set; }
        public string? NombreEmbarcador { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteCodTransAereo? CodigoTransportistaNavigation { get; set; }
        public virtual CartaPorteTipoPermiso? PermSctNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalEmbarcNavigation { get; set; }
        public virtual Pai1? ResidenciaFiscalTransporNavigation { get; set; }
    }
}
