using Microsoft.EntityFrameworkCore;
using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public class EtudeRepository : IEtudeRepository
    {
        public readonly SiafContext context;

        public EtudeRepository(SiafContext context)
        {
            this.context = context;
        }
        public List<EtudeTable> FindAll()
        {
            return context.EtudeTables.Include(x => x.IdClientNavigation).OrderByDescending(x => x.Id).ToList();
        }
        public void add(EtudeTable et)
        {
            context.Add(et);
            context.SaveChanges();

        }
        public void remove(EtudeTable et)
        {

        }
        public EtudeTable getbyFT(string ft)
        {
            return null;
        }
        public EtudeTable getbyyear(int year)
        {
            return null;
        }
        public EtudeTable getbyId(int id)
        {
            return context.EtudeTables.FirstOrDefault(x => x.Id == id);
        }
        public EtudeTable getbyResp(string name)
        {
            return null;
        }
        public void update(EtudeTable et)
        {
            context.Update(et);
            context.SaveChanges();
        }

        public string GetLastNumber()
        {

            var x = context.EtudeTables.FirstOrDefault(x => x.Id == context.EtudeTables.Max(x => x.Id));
            if (x == null)
                return "001";
            else
                return x.NumFicheTechnique;


        }

        public void SetEndEtude(int id)
        {
            EtudeTable e = context.EtudeTables.FirstOrDefault(x => x.Id == id);
            e.DateFin = DateTime.Now;
            context.EtudeTables.Update(e);
            context.SaveChanges();
        }

        //public void SetEndProject(int id)
        //{
        //    EtudeTable e = context.EtudeTables.FirstOrDefault(x => x.Id == id);
        //    e.DateFin = DateTime.Now;
        //    context.EtudeTables.Update(e);
        //    context.SaveChanges();
        //}
    }
}
