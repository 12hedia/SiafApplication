using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public class ClientRepository : IClientRepository
    {
        public readonly SiafContext context;

        public ClientRepository(SiafContext context)
        {
            this.context = context;
        }
        public void AjouterClient(ClientTable client)
        {
            ClientTable cl = new ClientTable();
            cl.Adress = client.Adress;
            cl.Name = client.Name;
            cl.Tel = client.Tel;
            cl.Email = client.Email;
            cl.Fax = client.Fax;
            cl.Mf = client.Mf;

            try
            {

                context.ClientTables.Add(cl);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string x = "";
                x = "";


            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }



        public ClientTable findByName(string name)
        {
            return context.ClientTables.FirstOrDefault(x => x.Name == name);
        }

        public ClientTable findById(int id)
        {
            return context.ClientTables.FirstOrDefault(x => x.Id == id);
        }

        public List<ClientTable> GetAll()
        {
            return context.ClientTables.ToList();
            //throw new NotImplementedException();
        }

        public void updateClient(ClientTable client)
        {
            context.ClientTables.Update(client);
            context.SaveChanges();
        }
    }
}
