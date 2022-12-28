using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsTransportista
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Placa { get; set; }
        public string? NombreConductor { get; set; }
        public string? Licencia { get; set; }
        public string? Cedula { get; set; }
        public string? Moto { get; set; }
        public string? Chasis { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
