namespace SiafManagementStudio.Models
{
    public partial class MachineTable
    {
        public MachineTable()
        {
            FabriquerTables = new HashSet<FabriquerTable>();
        }

        public int IdMachine { get; set; }
        public string NomMachine { get; set; } = null!;
        public string IpMachine { get; set; } = null!;
        public int IdFab { get; set; }

        public virtual TypeFabTable IdFabNavigation { get; set; } = null!;
        public virtual ICollection<FabriquerTable> FabriquerTables { get; set; }
    }
}
