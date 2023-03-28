using Microsoft.EntityFrameworkCore;
using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public class PersonnelRepository : IPersonnelRepository
    {
        public readonly SiafContext context;
        public PersonnelRepository(SiafContext context)
        {
            this.context = context;
        }
        public void Ajouter(PersonnelTable pr)
        {
            context.PersonnelTables.Add(pr);
            context.SaveChanges();

        }
        public void Update(PersonnelTable pr)
        {
            context.PersonnelTables.Update(pr);
            context.SaveChanges();
        }
        public PersonnelTable getByName(string name, string subname)
        {
            return context.PersonnelTables.FirstOrDefault(x => x.Nom == name && x.Prenom == subname);

        }
        public PersonnelTable getByid(int id)
        {
            return context.PersonnelTables.Include(x => x.Departement).FirstOrDefault(x => x.Id == id);
        }
        public void delete(PersonnelTable pr)
        {

        }

        public List<PersonnelTable> getAll()
        {
            return context.PersonnelTables.Include(x => x.Departement).ToList();
        }
    }
}
