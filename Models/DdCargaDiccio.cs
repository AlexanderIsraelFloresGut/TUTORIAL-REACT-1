using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdCargaDiccio
    {
        public string NombreTabla { get; set; } = null!;
        public string PropietTabla { get; set; } = null!;
        public string NombreColum { get; set; } = null!;
        public string TipoColum { get; set; } = null!;
        public string? TamanoColum { get; set; }
        public string Nulidad { get; set; } = null!;
        public string EsPk { get; set; } = null!;
        public string EsFk { get; set; } = null!;
        public string? Comentario { get; set; }
        public string? ValorDefault { get; set; }
        public string? ConstrColum { get; set; }
        public string DomEditEnprocmas { get; set; } = null!;
        public string DomEditPrimvez { get; set; } = null!;
        public string DomModoCase { get; set; } = null!;
        public string DomTipoMascara { get; set; } = null!;
        public string DomEsAutocalc { get; set; } = null!;
        public string DomUsoModvisual { get; set; } = null!;
        public string DomSoloLect { get; set; } = null!;
        public string DomEsRequer { get; set; } = null!;
        public string DomMostrarComo { get; set; } = null!;
        public string DomTipoConsec { get; set; } = null!;
        public string DomFormatojustif { get; set; } = null!;
        public string DomValoretiqueta { get; set; } = null!;
        public string DomMostrarenf1 { get; set; } = null!;
        public string EditEnprocmas { get; set; } = null!;
        public string EditPrimvez { get; set; } = null!;
        public string ModoCase { get; set; } = null!;
        public string TipoMascara { get; set; } = null!;
        public string EsAutocalc { get; set; } = null!;
        public string UsoModvisual { get; set; } = null!;
        public string SoloLect { get; set; } = null!;
        public string EsRequer { get; set; } = null!;
        public string MostrarComo { get; set; } = null!;
        public string TipoConsec { get; set; } = null!;
        public string Formatojustif { get; set; } = null!;
        public string Valoretiqueta { get; set; } = null!;
        public string Mostrarenf1 { get; set; } = null!;
        public int CargaDiccio { get; set; }
        public string? Modulo { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
