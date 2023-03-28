namespace SiafManagementStudio.Models
{
    public partial class MatiereTable
    {
        public MatiereTable()
        {
            IdPieces = new HashSet<PieceTable>();
        }

        public int IdMatiere { get; set; }
        public string NomMatiere { get; set; } = null!;
        public double PrixU { get; set; }
        public double MassVolum { get; set; }
        public DateTime DateAjout { get; set; }

        public virtual MatierePlatTable? MatierePlatTable { get; set; }
        public virtual MatiereRondTable? MatiereRondTable { get; set; }

        public virtual ICollection<PieceTable> IdPieces { get; set; }
    }
}
