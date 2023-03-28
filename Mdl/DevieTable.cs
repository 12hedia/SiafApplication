namespace SiafManagementStudio.Models
{
    public partial class DevieTable
    {
        public int IdDev { get; set; }
        public string NumDev { get; set; } = null!;
        public int IdClient { get; set; }
        public double TotPrix { get; set; }
        public double TotCout { get; set; }
        public int IdDevise { get; set; }
        public int NbHeurTt { get; set; }
        public DateTime DateCreation { get; set; }
        public string IdUser { get; set; } = null!;

        public virtual ClientTable IdClientNavigation { get; set; } = null!;
        public virtual DeviseTable IdDeviseNavigation { get; set; } = null!;
        public virtual AspNetUser IdUserNavigation { get; set; } = null!;
    }
}
