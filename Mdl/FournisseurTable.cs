namespace SiafManagementStudio.Models
{
    public partial class FournisseurTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string? Fax { get; set; }
        public string Email { get; set; } = null!;
        public string Mf { get; set; } = null!;
    }
}
