using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VContaElectronicaDocumento
    {
        public string Asiento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; } = null!;
        public string CuentaContable { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal DebitoLocal { get; set; }
        public decimal CreditoLocal { get; set; }
        public string TipoAsiento { get; set; } = null!;
        public string? DocumentoCp { get; set; }
        public string? CodElectronico { get; set; }
        public string DescripcionEf { get; set; } = null!;
        public string? Beneficiario { get; set; }
        public string? ChequeCuenta { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public decimal? Monto { get; set; }
        public string? Nombre { get; set; }
        public string? Contribuyente { get; set; }
        public string? CuentaDestino { get; set; }
        public string? Doc { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal? TipoCambio { get; set; }
        public string? FolioSat { get; set; }
        public string? NitEmisor { get; set; }
        public string? Moneda { get; set; }
        public string? BancoOri { get; set; }
        public string? BancoDest { get; set; }
        public string Mayor { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public string CltProvOrigen { get; set; } = null!;
        public string OrigenVista { get; set; } = null!;
        public string Modulo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string CategoriaProv { get; set; } = null!;
        public string NitProveedor { get; set; } = null!;
    }
}
