using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public class DepartementRepository : IDepartementRepository
    {
        public readonly SiafContext context;
        public DepartementRepository(SiafContext con)
        {
            this.context = con;
        }

        public List<DepartementTable> getAll()
        {
            return context.DepartementTables.ToList();
        }
        public void ajouter(DepartementTable dp)
        {
            context.DepartementTables.Add(dp);
            context.SaveChanges();
        }
        public DepartementTable getbyName(string name)
        {
            return context.DepartementTables.FirstOrDefault(x => x.Depatement == name);
        }
        public DepartementTable getbyId(int id)
        {
            return context.DepartementTables.FirstOrDefault(x => x.Id == id);
        }
        public void update(DepartementTable dp)
        {
            context.DepartementTables.Update(dp);
            context.SaveChanges();
        }
        public void delete(DepartementTable dp)
        {
            context.DepartementTables.Remove(dp);
            context.SaveChanges();
        }

    }
}
