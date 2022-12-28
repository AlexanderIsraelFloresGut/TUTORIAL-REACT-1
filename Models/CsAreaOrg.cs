using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsAreaOrg
    {
        public CsAreaOrg()
        {
            CsEmpleadoAreas = new HashSet<CsEmpleadoArea>();
            InverseParentAreaOrganizacionalNavigation = new HashSet<CsAreaOrg>();
        }

        public Guid AreaOrganizacional { get; set; }
        public string Descripcion { get; set; } = null!;
        public int NivelArea { get; set; }
        public string Departamento { get; set; } = null!;
        public Guid? ParentAreaOrganizacional { get; set; }
        public string Encargado { get; set; } = null!;

        public virtual Departamento1 DepartamentoNavigation { get; set; } = null!;
        public virtual Empleado1 EncargadoNavigation { get; set; } = null!;
        public virtual CsAreaOrg? ParentAreaOrganizacionalNavigation { get; set; }
        public virtual ICollection<CsEmpleadoArea> CsEmpleadoAreas { get; set; }
        public virtual ICollection<CsAreaOrg> InverseParentAreaOrganizacionalNavigation { get; set; }
    }
}
