using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Accion
    {
        public Accion()
        {
            ModuloInstalados = new HashSet<ModuloInstalado>();
            OpcionConfigMantenimientoNavigations = new HashSet<OpcionConfig>();
            OpcionConfigModuloNavigations = new HashSet<OpcionConfig>();
        }

        public int Accion1 { get; set; }
        public string Nombreaccion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Nombreconstante { get; set; } = null!;
        public string Esmodulo { get; set; } = null!;
        public string Esestandar { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Subtipo { get; set; } = null!;
        public string? Tabla { get; set; }
        public string? Invocacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AccionVersion AccionVersion { get; set; } = null!;
        public virtual OpcionConfig OpcionConfigAccionNavigation { get; set; } = null!;
        public virtual ICollection<ModuloInstalado> ModuloInstalados { get; set; }
        public virtual ICollection<OpcionConfig> OpcionConfigMantenimientoNavigations { get; set; }
        public virtual ICollection<OpcionConfig> OpcionConfigModuloNavigations { get; set; }
    }
}
