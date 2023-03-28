namespace SiafManagementStudio.Models
{
    public partial class ClientTable
    {
        public ClientTable()
        {
            DevieTables = new HashSet<DevieTable>();
            EtudeTables = new HashSet<EtudeTable>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string? Fax { get; set; }
        public string Email { get; set; } = null!;
        public string Mf { get; set; } = null!;

        public virtual ICollection<DevieTable> DevieTables { get; set; }
        public virtual ICollection<EtudeTable> EtudeTables { get; set; }
    }
}
