namespace SiafManagementStudio.Models
{
    public partial class SoutretanceTable
    {
        public SoutretanceTable()
        {
            PieceSoutretTables = new HashSet<PieceSoutretTable>();
        }

        public int IdSout { get; set; }
        public string DesigSout { get; set; } = null!;
        public double CoutSout { get; set; }

        public virtual ICollection<PieceSoutretTable> PieceSoutretTables { get; set; }
    }
}
