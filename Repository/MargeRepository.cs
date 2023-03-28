using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface MargeRepository
    {
        void AjouterMarge(MargeTable marge);

        List<MargeTable> GetAll();

        MargeTable findByName(string name);

        void updateDevie(MargeTable marge);

        void delete(int id);
        MargeTable findById(int id);

    }
}
