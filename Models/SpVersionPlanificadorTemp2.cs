using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SpVersionPlanificadorTemp2
    {
        public int PkspVersionTemp { get; set; }
        public string Fkplanificador { get; set; } = null!;
        public DateTime FechaIniPlanificador { get; set; }
        public DateTime FechaFinPlanificador { get; set; }
        public int VersionPlanificador { get; set; }
    }
}
