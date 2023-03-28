using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface MatiereRepository
    {

        void AjouterMatierePlat(MatiereTable Matiere);

        List<MatiereTable> GetAll();

        MatiereTable findByName(string name);

        void updateMatiere(MatiereTable Matiere);

        void delete(int id);
        MatiereTable findById(int id);

    }
}
