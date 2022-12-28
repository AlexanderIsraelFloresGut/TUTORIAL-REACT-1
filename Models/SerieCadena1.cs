using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SerieCadena1
    {
        public SerieCadena1()
        {
            BoletaInvFisico1SerieCadenaDispNavigations = new HashSet<BoletaInvFisico1>();
            BoletaInvFisico1SerieCadenaNoaprNavigations = new HashSet<BoletaInvFisico1>();
            BoletaInvFisico1SerieCadenaVencNavigations = new HashSet<BoletaInvFisico1>();
            DesgloseArtTmp1s = new HashSet<DesgloseArtTmp1>();
            DespachoDetalle1s = new HashSet<DespachoDetalle1>();
            DetLinEmbarque1s = new HashSet<DetLinEmbarque1>();
            DevolLinEmbarque1s = new HashSet<DevolLinEmbarque1>();
            EmbarqueLinea1s = new HashSet<EmbarqueLinea1>();
            ExistenciaReserva1s = new HashSet<ExistenciaReserva1>();
            FacturaLinea1SerieCadAceptadaNavigations = new HashSet<FacturaLinea1>();
            FacturaLinea1SerieCadNoAceptNavigations = new HashSet<FacturaLinea1>();
            FacturaLinea1SerieCadenaNavigations = new HashSet<FacturaLinea1>();
            LineaDocInv1s = new HashSet<LineaDocInv1>();
            OpOperDetProd1s = new HashSet<OpOperDetProd1>();
            SerieCadenaDet1s = new HashSet<SerieCadenaDet1>();
            TransaccionInv1s = new HashSet<TransaccionInv1>();
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
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1SerieCadenaDispNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1SerieCadenaNoaprNavigations { get; set; }
        public virtual ICollection<BoletaInvFisico1> BoletaInvFisico1SerieCadenaVencNavigations { get; set; }
        public virtual ICollection<DesgloseArtTmp1> DesgloseArtTmp1s { get; set; }
        public virtual ICollection<DespachoDetalle1> DespachoDetalle1s { get; set; }
        public virtual ICollection<DetLinEmbarque1> DetLinEmbarque1s { get; set; }
        public virtual ICollection<DevolLinEmbarque1> DevolLinEmbarque1s { get; set; }
        public virtual ICollection<EmbarqueLinea1> EmbarqueLinea1s { get; set; }
        public virtual ICollection<ExistenciaReserva1> ExistenciaReserva1s { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1SerieCadAceptadaNavigations { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1SerieCadNoAceptNavigations { get; set; }
        public virtual ICollection<FacturaLinea1> FacturaLinea1SerieCadenaNavigations { get; set; }
        public virtual ICollection<LineaDocInv1> LineaDocInv1s { get; set; }
        public virtual ICollection<OpOperDetProd1> OpOperDetProd1s { get; set; }
        public virtual ICollection<SerieCadenaDet1> SerieCadenaDet1s { get; set; }
        public virtual ICollection<TransaccionInv1> TransaccionInv1s { get; set; }
    }
}
