using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface TypeFabRepository
    {

        void AjouterTypeFab(TypeFabTable typeFab);

        List<TypeFabTable> GetAll();

        TypeFabTable findByName(string name);

        void updateTypeFab(TypeFabTable typeFab);

        void delete(int id);
        TypeFabTable findById(int id);

    }
}
