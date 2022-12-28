using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiMetadetalle1
    {
        public int Meta { get; set; }
        public int Metadetalle { get; set; }
        public string Codigo1 { get; set; } = null!;
        public string Codigo2 { get; set; } = null!;
        public DateTime Mes { get; set; }
        public decimal Valormeta { get; set; }
    }
}
