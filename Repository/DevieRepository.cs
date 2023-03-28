using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface DevieRepository
    {

        void AjouterDevie(DevieTable Devie);

        List<DevieTable> GetAll();

        DevieTable findByName(string name);

        void updateDevie(DevieTable devie);

        void delete(int id);
        DevieTable findById(int id);

    }
}
