namespace SiafManagementStudio.Models
{
    public partial class TypeFabTable
    {
        public TypeFabTable()
        {
            MachineTables = new HashSet<MachineTable>();
        }

        public int IdFab { get; set; }
        public string? TypeFab { get; set; }

        public virtual ICollection<MachineTable> MachineTables { get; set; }
    }
}
