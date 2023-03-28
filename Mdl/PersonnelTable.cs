namespace SiafManagementStudio.Models
{
    public partial class PersonnelTable
    {
        public PersonnelTable()
        {
            EtudeTables = new HashSet<EtudeTable>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string Ville { get; set; } = null!;
        public int Cp { get; set; }
        public string Civilite { get; set; } = null!;
        public string MatriculeCnss { get; set; } = null!;
        public int Matricule { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Niveau { get; set; } = null!;
        public int Cin { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; } = null!;
        public int DepartementId { get; set; }

        public virtual DepartementTable Departement { get; set; } = null!;
        public virtual ICollection<EtudeTable> EtudeTables { get; set; }
    }
}
