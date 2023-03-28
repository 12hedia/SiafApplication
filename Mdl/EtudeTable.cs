namespace SiafManagementStudio.Models
{
    public partial class EtudeTable
    {
        public int Id { get; set; }
        public string NumFicheTechnique { get; set; } = null!;
        public string NomDeProjet { get; set; } = null!;
        public string? NumBc { get; set; }
        public int NbrFt { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFinPrev { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime DateLivraison { get; set; }
        public int IdClientNavigationId { get; set; }
        public string IdPersoNavigationId { get; set; } = null!;
        public int? PersonnelTableId { get; set; }

        public virtual ClientTable IdClientNavigation { get; set; } = null!;
        public virtual AspNetUser IdPersoNavigation { get; set; } = null!;
        public virtual PersonnelTable? PersonnelTable { get; set; }
    }
}
