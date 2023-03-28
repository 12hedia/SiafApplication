namespace SiafManagementStudio.Models
{
    public partial class FabriquerTable
    {
        public int IdMachine { get; set; }
        public int IdPiece { get; set; }
        public DateTime DateFabr { get; set; }

        public virtual MachineTable IdMachineNavigation { get; set; } = null!;
        public virtual PieceTable IdPieceNavigation { get; set; } = null!;
    }
}
