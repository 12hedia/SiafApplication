using System.ComponentModel.DataAnnotations.Schema;

namespace SiafManagementStudio.Models
{
    public partial class MatierePlatTable
    {

        [ForeignKey("IdMatiereNavigation")]
        public int IdMatiere2 { get; set; }

        public int IdMatiere { get; set; }
        public double Houteur { get; set; }
        public double Largeur { get; set; }
        public double Longueur { get; set; }

        public virtual MatiereTable IdMatiereNavigation { get; set; }
    }
}
