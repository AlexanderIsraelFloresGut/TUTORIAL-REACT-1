using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SerieCadena
    {
        public SerieCadena()
        {
            BoletaInvFisicoSerieCadenaDispNavigations = new HashSet<BoletaInvFisico>();
            BoletaInvFisicoSerieCadenaNoaprNavigations = new HashSet<BoletaInvFisico>();
            BoletaInvFisicoSerieCadenaVencNavigations = new HashSet<BoletaInvFisico>();
            DesgloseArtTmps = new HashSet<DesgloseArtTmp>();
            DespachoDetalles = new HashSet<DespachoDetalle>();
            DetLinEmbarques = new HashSet<DetLinEmbarque>();
            DevolLinEmbarques = new HashSet<DevolLinEmbarque>();
            EmbarqueLineas = new HashSet<EmbarqueLinea>();
            ExistenciaReservas = new HashSet<ExistenciaReserva>();
            FacturaLineaSerieCadAceptadaNavigations = new HashSet<FacturaLinea>();
            FacturaLineaSerieCadNoAceptNavigations = new HashSet<FacturaLinea>();
            FacturaLineaSerieCadenaNavigations = new HashSet<FacturaLinea>();
            LineaDocInvs = new HashSet<LineaDocInv>();
            OpOperDetProds = new HashSet<OpOperDetProd>();
            SerieCadenaDets = new HashSet<SerieCadenaDet>();
            TransaccionInvs = new HashSet<TransaccionInv>();
        }

        public int SerieCadena1 { get; set; }
        public string ModuloOrigen { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicoSerieCadenaDispNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicoSerieCadenaNoaprNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico> BoletaInvFisicoSerieCadenaVencNavigations { get; set; }
        public virtual ICollection<DesgloseArtTmp> DesgloseArtTmps { get; set; }
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }
        public virtual ICollection<DetLinEmbarque> DetLinEmbarques { get; set; }
        public virtual ICollection<DevolLinEmbarque> DevolLinEmbarques { get; set; }
        public virtual ICollection<EmbarqueLinea> EmbarqueLineas { get; set; }
        public virtual ICollection<ExistenciaReserva> ExistenciaReservas { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineaSerieCadAceptadaNavigations { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineaSerieCadNoAceptNavigations { get; set; }
        public virtual ICollection<FacturaLinea> FacturaLineaSerieCadenaNavigations { get; set; }
        public virtual ICollection<LineaDocInv> LineaDocInvs { get; set; }
        public virtual ICollection<OpOperDetProd> OpOperDetProds { get; set; }
        public virtual ICollection<SerieCadenaDet> SerieCadenaDets { get; set; }
        public virtual ICollection<TransaccionInv> TransaccionInvs { get; set; }
    }
}
