using System.ComponentModel.DataAnnotations.Schema;

namespace SiafManagementStudio.Models
{
    public partial class MatiereRondTable
    {
        [ForeignKey("IdMatiereNavigation")]
        public int IdMatiere1 { get; set; }
        public int IdMatiere { get; set; }
        public double Diametre { get; set; }
        public double Longueur { get; set; }

        public virtual MatiereTable IdMatiereNavigation { get; set; }
    }
}
