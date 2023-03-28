using SiafManagementStudio.Models;

namespace SiafManagementStudio.Repository
{
    public interface IEtudeRepository
    {
        List<EtudeTable> FindAll();
        void add(EtudeTable et);
        EtudeTable getbyFT(string ft);
        EtudeTable getbyId(int id);
        EtudeTable getbyResp(string name);
        EtudeTable getbyyear(int year);
        void remove(EtudeTable et);
        void update(EtudeTable et);
        string GetLastNumber();
        void SetEndEtude(int id);
        //void SetEndProject(int id);
    }
}