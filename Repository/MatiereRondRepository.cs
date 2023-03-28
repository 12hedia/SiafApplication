using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface MatiereRondRepository
    {

        void AjouterMatiereRond(MatiereRondTable matiereRond);

        List<MatiereRondTable> GetAll();

        DevieTable findByName(string name);

        void updateMatiereRond(MatiereRondTable matiereRond);

        void delete(int id);
        MatiereRondTable findById(int id);


    }
}
