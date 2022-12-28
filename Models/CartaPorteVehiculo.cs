using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteVehiculo
    {
        public string Vehiculo { get; set; } = null!;
        public string ConfigVehicular { get; set; } = null!;
        public string PlacaVm { get; set; } = null!;
        public int AnioModeloVm { get; set; }
        public string AseguraRespCivil { get; set; } = null!;
        public string PolizaRespCivil { get; set; } = null!;
        public string? AseguraMedAmbiente { get; set; }
        public string? PolizaMedAmbiente { get; set; }
        public string? AseguraCarga { get; set; }
        public string? PolizaCarga { get; set; }
        public decimal? PrimaSeguro { get; set; }
        public string PermSct { get; set; } = null!;
        public string NumPermisoSct { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CartaPorteConfigVehicular ConfigVehicularNavigation { get; set; } = null!;
        public virtual CartaPorteTipoPermiso PermSctNavigation { get; set; } = null!;
    }
}
