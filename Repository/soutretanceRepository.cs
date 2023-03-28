

using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface soutretanceRepository
    {


        void Ajoutersoutretance(SoutretanceTable soutretance);

        List<SoutretanceTable> GetAll();

        SoutretanceTable findByName(string name);

        void updatesoutretance(SoutretanceTable soutretance);

        void delete(int id);
        SoutretanceTable findById(int id);


    }
}
