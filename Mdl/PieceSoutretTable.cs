namespace SiafManagementStudio.Models
{
    public partial class PieceSoutretTable
    {
        public int IdPiece { get; set; }
        public int IdSout { get; set; }
        public DateTime DateSout { get; set; }

        public virtual PieceTable IdPieceNavigation { get; set; } = null!;
        public virtual SoutretanceTable IdSoutNavigation { get; set; } = null!;
    }
}
