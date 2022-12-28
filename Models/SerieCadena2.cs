using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SerieCadena2
    {
        public SerieCadena2()
        {
            BoletaInvFisico2SerieCadenaDispNavigations = new HashSet<BoletaInvFisico2>();
            BoletaInvFisico2SerieCadenaNoaprNavigations = new HashSet<BoletaInvFisico2>();
            BoletaInvFisico2SerieCadenaVencNavigations = new HashSet<BoletaInvFisico2>();
            DesgloseArtTmp2s = new HashSet<DesgloseArtTmp2>();
            DespachoDetalle2s = new HashSet<DespachoDetalle2>();
            DetLinEmbarque2s = new HashSet<DetLinEmbarque2>();
            DevolLinEmbarque2s = new HashSet<DevolLinEmbarque2>();
            EmbarqueLinea2s = new HashSet<EmbarqueLinea2>();
            ExistenciaReserva2s = new HashSet<ExistenciaReserva2>();
            FacturaLinea2SerieCadAceptadaNavigations = new HashSet<FacturaLinea2>();
            FacturaLinea2SerieCadNoAceptNavigations = new HashSet<FacturaLinea2>();
            FacturaLinea2SerieCadenaNavigations = new HashSet<FacturaLinea2>();
            LineaDocInv2s = new HashSet<LineaDocInv2>();
            OpOperDetProd2s = new HashSet<OpOperDetProd2>();
            SerieCadenaDet2s = new HashSet<SerieCadenaDet2>();
            TransaccionInv2s = new HashSet<TransaccionInv2>();
        }

        public int SerieCadena { get; set; }
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
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2SerieCadenaDispNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2SerieCadenaNoaprNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico2> BoletaInvFisico2SerieCadenaVencNavigations { get; set; }
        public virtual ICollection<DesgloseArtTmp2> DesgloseArtTmp2s { get; set; }
        public virtual ICollection<DespachoDetalle2> DespachoDetalle2s { get; set; }
        public virtual ICollection<DetLinEmbarque2> DetLinEmbarque2s { get; set; }
        public virtual ICollection<DevolLinEmbarque2> DevolLinEmbarque2s { get; set; }
        public virtual ICollection<EmbarqueLinea2> EmbarqueLinea2s { get; set; }
        public virtual ICollection<ExistenciaReserva2> ExistenciaReserva2s { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2SerieCadAceptadaNavigations { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2SerieCadNoAceptNavigations { get; set; }
        public virtual ICollection<FacturaLinea2> FacturaLinea2SerieCadenaNavigations { get; set; }
        public virtual ICollection<LineaDocInv2> LineaDocInv2s { get; set; }
        public virtual ICollection<OpOperDetProd2> OpOperDetProd2s { get; set; }
        public virtual ICollection<SerieCadenaDet2> SerieCadenaDet2s { get; set; }
        public virtual ICollection<TransaccionInv2> TransaccionInv2s { get; set; }
    }
}
