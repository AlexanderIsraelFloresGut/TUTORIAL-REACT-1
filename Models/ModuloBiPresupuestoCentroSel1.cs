using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModuloBiPresupuestoCentroSel1
    {
        public string? CentroCosto { get; set; }
        public string Descripcion { get; set; } = null!;
        public string CentroPadre { get; set; } = null!;
        public string? Presupuesto { get; set; }
        public string? Version { get; set; }
        public string EnPresupuesto { get; set; } = null!;
        public Guid? Rowpointer { get; set; }
        public byte? Noteexistsflag { get; set; }
        public DateTime? Recorddate { get; set; }
        public string? Createdby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
