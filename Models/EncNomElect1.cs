using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EncNomElect1
    {
        public DateTime Periodo { get; set; }
        public DateTime FechaInicioPer { get; set; }
        public DateTime FechaFinPer { get; set; }
        public DateTime FechaGenPer { get; set; }
        public string? Pais { get; set; }
        public string? Departamento { get; set; }
        public string? Municipio { get; set; }
        public string? Idioma { get; set; }
        public string? Version { get; set; }
        public string? Ambiente { get; set; }
        public string? TipoXml { get; set; }
        public DateTime? FechaGen { get; set; }
        public string? HoraGen { get; set; }
        public string? TipoMoneda { get; set; }
        public decimal Trm { get; set; }
        public string? RazonSocial { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? PrimerNombre { get; set; }
        public string? OtrosNombres { get; set; }
        public string? Nit { get; set; }
        public string? Dv { get; set; }
        public string? PaisEmp { get; set; }
        public string? DepartamentoEmp { get; set; }
        public string? MunicipioEmp { get; set; }
        public string? DireccionEmp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
