using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface IDepartementRepository
    {
        void ajouter(DepartementTable dp);
        void delete(DepartementTable dp);
        List<DepartementTable> getAll();
        DepartementTable getbyId(int id);
        DepartementTable getbyName(string name);
        void update(DepartementTable dp);
    }
}