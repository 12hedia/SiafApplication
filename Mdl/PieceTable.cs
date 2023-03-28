namespace SiafManagementStudio.Models
{
    public partial class PieceTable
    {
        public PieceTable()
        {
            FabriquerTables = new HashSet<FabriquerTable>();
            PieceSoutretTables = new HashSet<PieceSoutretTable>();
            IdMatieres = new HashSet<MatiereTable>();
        }

        public int IdPiece { get; set; }
        public string DesigPiece { get; set; } = null!;
        public int Quantite { get; set; }
        public double PrixVenteU { get; set; }
        public double PrixRevient { get; set; }
        public double PrixTot { get; set; }
        public double CoutMatier { get; set; }
        public int? IdDevie { get; set; }

        public virtual ICollection<FabriquerTable> FabriquerTables { get; set; }
        public virtual ICollection<PieceSoutretTable> PieceSoutretTables { get; set; }

        public virtual ICollection<MatiereTable> IdMatieres { get; set; }
    }
}
