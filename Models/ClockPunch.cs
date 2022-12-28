using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ClockPunch
    {
        public string Empleado { get; set; } = null!;
        public DateTime FechaMarcada { get; set; }
    }
}
