namespace SiafManagementStudio.Models
{
    public partial class DepartementTable
    {
        public DepartementTable()
        {
            PersonnelTables = new HashSet<PersonnelTable>();
        }

        public int Id { get; set; }
        public string Depatement { get; set; } = null!;

        public virtual ICollection<PersonnelTable> PersonnelTables { get; set; }
    }
}
