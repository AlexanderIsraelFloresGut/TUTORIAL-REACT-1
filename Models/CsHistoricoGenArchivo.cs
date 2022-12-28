using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CsHistoricoGenArchivo
    {
        public Guid Historico { get; set; }
        public string Usuario { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public int NumeroNomina { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaGenerado { get; set; }
        public string EntidadFinanciera { get; set; } = null!;
        public decimal NetoTotal { get; set; }
    }
}
