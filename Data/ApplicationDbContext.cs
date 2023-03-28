using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiafManagementStudio.Models;

namespace SiafManagementStudio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<ClientTable> ClientTables { get; set; }

        public virtual DbSet<DevieTable> DevieTables { get; set; }

        public virtual DbSet<FabriquerTable> FabriquerTables { get; set; }

        public virtual DbSet<MargeTable> MargeTables { get; set; }

        public virtual DbSet<MatierePlatTable> MatierePlatTables { get; set; }

        public virtual DbSet<MatiereRondTable> MatiereRoundTables { get; set; }

        //  public virtual DbSet<PieceMatiereTable> PieceMatiereTables { get; set; }

        public virtual DbSet<PieceSoutretTable> PieceSoutretTables { get; set; }

        public virtual DbSet<PieceTable> PieceTables { get; set; }

        public virtual DbSet<SoutretanceTable> SoutretanceTables { get; set; }

        public virtual DbSet<TypeFabTable> TypeFabTables { get; set; }

        public virtual DbSet<DepartementTable> DepartementTables { get; set; }

        public virtual DbSet<DeviseTable> DeviseTables { get; set; }

        public virtual DbSet<EtudeTable> EtudeTables { get; set; }

        public virtual DbSet<FournisseurTable> FournisseurTables { get; set; }

        public virtual DbSet<MachineTable> MachineTables { get; set; }

        public virtual DbSet<MatiereTable> MatiereTables { get; set; }

        public virtual DbSet<OperationTable> OperationTables { get; set; }

        public virtual DbSet<PersonnelTable> PersonnelTables { get; set; }

        public virtual DbSet<SoutraitantTable> SoutraitantTables { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


    }
}