using SiafManagementStudio.Models;


namespace SiafManagementStudio.Repository
{
    public interface PieceSoutretRepository
    {

        void AjouterPieceScoutret(PieceSoutretTable PieceScoutret);

        List<PieceSoutretTable> GetAll();

        PieceSoutretTable findByName(string name);

        void updatePieceSoutret(PieceSoutretTable PieceScoutret);

        void delete(int id);
        PieceSoutretTable findById(int id);



    }
}
