using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BomUsuario
    {
        public string Usuario { get; set; } = null!;
        public string NivelExplosion { get; set; } = null!;
        public string CkExistencia { get; set; } = null!;
        public string ConsumoReserva { get; set; } = null!;
        public DateTime? FhExplosion { get; set; }
        public string InvCuarentena { get; set; } = null!;
        public string ImprimeCostos { get; set; } = null!;
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
    }
}
