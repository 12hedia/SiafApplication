using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface IClientRepository
    {
        // app_gest_stock.Repository.IArrivageRepository



        void AjouterClient(ClientTable client);

        List<ClientTable> GetAll();

        ClientTable findByName(string name);

        void updateClient(ClientTable client);

        void delete(int id);
        ClientTable findById(int id);
    }

}

