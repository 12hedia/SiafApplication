using SiafManagementStudio.Models;

namespace SiafManagementStudio.ADO
{
    public class etudeADO : EtudeTable
    {
        public EtudeTable etude;
        public string username;
        public etudeADO(EtudeTable et, string user)
        {
            this.etude = et;
            this.username = user;
        }
    }
}
