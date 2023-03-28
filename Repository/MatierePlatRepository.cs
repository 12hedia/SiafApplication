using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface MatierePlatRepository
    {

        void AjouterMatierePlat(MatierePlatTable MatierePlat);

        List<MatierePlatTable> GetAll();

        DevieTable findByName(string name);

        void updateMatierePlat(MatierePlatTable MatierePlat);

        void delete(int id);
        MatierePlatTable findById(int id);

    }
}
