using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface IPersonnelRepository
    {
        List<PersonnelTable> getAll();
        void Ajouter(PersonnelTable pr);
        void delete(PersonnelTable pr);
        PersonnelTable getByid(int id);
        PersonnelTable getByName(string name, string subname);
        void Update(PersonnelTable pr);
    }
}