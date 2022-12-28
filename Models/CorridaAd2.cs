using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CorridaAd2
    {
        public CorridaAd2()
        {
            DetalleCorridum2s = new HashSet<DetalleCorridum2>();
        }

        public int CorridaAd { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public short CantPlantillas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<DetalleCorridum2> DetalleCorridum2s { get; set; }
    }
}
