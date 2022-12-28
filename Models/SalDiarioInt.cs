﻿using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SalDiarioInt
    {
        public SalDiarioInt()
        {
            SalDiarioIntCons = new HashSet<SalDiarioIntCon>();
            SalDiarioIntDets = new HashSet<SalDiarioIntDet>();
            SalDiarioIntEmps = new HashSet<SalDiarioIntEmp>();
        }

        public int Consecutivo { get; set; }
        public string Aplicado { get; set; } = null!;
        public string Nomina { get; set; } = null!;
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal DiasSdiv { get; set; }
        public string TipoAccion { get; set; } = null!;
        public DateTime FechaAccion { get; set; }
        public DateTime FechaRige { get; set; }
        public decimal SalMinimoDf { get; set; }
        public decimal SalMinimoZona { get; set; }
        public decimal TopeSdi { get; set; }
        public string DiasLaborados { get; set; } = null!;
        public string CalcularSdif { get; set; } = null!;
        public decimal DiasSd { get; set; }
        public string UsarSdivSd { get; set; } = null!;
        public int? RubroSdivSd { get; set; }
        public decimal? PorcFondoAhorro { get; set; }
        public decimal? TopeFondoAhorro { get; set; }
        public decimal? PorcDespensa { get; set; }
        public decimal? TopeDespensa { get; set; }
        public string? Rubro1Nombre { get; set; }
        public decimal? Rubro1 { get; set; }
        public string? Rubro2Nombre { get; set; }
        public decimal? Rubro2 { get; set; }
        public string? Rubro3Nombre { get; set; }
        public decimal? Rubro3 { get; set; }
        public string? Rubro4Nombre { get; set; }
        public decimal? Rubro4 { get; set; }
        public string? Notas { get; set; }
        public string NexcedeSalminzona { get; set; } = null!;
        public string FechaReferencia { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto DiasLaboradosNavigation { get; set; } = null!;
        public virtual Nomina NominaNavigation { get; set; } = null!;
        public virtual TipoAccion TipoAccionNavigation { get; set; } = null!;
        public virtual ICollection<SalDiarioIntCon> SalDiarioIntCons { get; set; }
        public virtual ICollection<SalDiarioIntDet> SalDiarioIntDets { get; set; }
        public virtual ICollection<SalDiarioIntEmp> SalDiarioIntEmps { get; set; }
    }
}
