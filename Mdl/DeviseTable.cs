namespace SiafManagementStudio.Models
{
    public partial class DeviseTable
    {
        public DeviseTable()
        {
            DevieTables = new HashSet<DevieTable>();
        }

        public int IdDevise { get; set; }
        public string Nom { get; set; } = null!;
        public double Valeur { get; set; }
        public DateTime DateModif { get; set; }

        public virtual ICollection<DevieTable> DevieTables { get; set; }
    }
}
