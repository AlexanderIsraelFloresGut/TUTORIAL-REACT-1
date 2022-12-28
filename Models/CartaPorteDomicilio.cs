using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CartaPorteDomicilio
    {
        public CartaPorteDomicilio()
        {
            CartaPorteArrendatarios = new HashSet<CartaPorteArrendatario>();
            CartaPorteNotificados = new HashSet<CartaPorteNotificado>();
            CartaPorteOperadors = new HashSet<CartaPorteOperador>();
            CartaPortePropietarios = new HashSet<CartaPortePropietario>();
            CartaPorteUbicacions = new HashSet<CartaPorteUbicacion>();
        }

        public string Domicilio { get; set; } = null!;
        public string? Calle { get; set; }
        public string? NumeroExterior { get; set; }
        public string? NumeroInterior { get; set; }
        public string? Colonia { get; set; }
        public string? Localidad { get; set; }
        public string? Referencia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? Codigopostal { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<CartaPorteArrendatario> CartaPorteArrendatarios { get; set; }
        public virtual ICollection<CartaPorteNotificado> CartaPorteNotificados { get; set; }
        public virtual ICollection<CartaPorteOperador> CartaPorteOperadors { get; set; }
        public virtual ICollection<CartaPortePropietario> CartaPortePropietarios { get; set; }
        public virtual ICollection<CartaPorteUbicacion> CartaPorteUbicacions { get; set; }
    }
}
