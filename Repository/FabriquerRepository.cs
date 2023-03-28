using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface FabriquerRepository
    {
        void AjouterFabriquer(FabriquerTable Fabriquer);

        List<FabriquerTable> GetAll();

        FabriquerTable findByName(string name);

        void updateDevie(FabriquerTable fabriquer);

        void delete(int id);
        FabriquerTable findById(int id);


    }
}
