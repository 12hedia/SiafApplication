using Microsoft.EntityFrameworkCore;

namespace SiafManagementStudio.Models
{
    public partial class SiafContext : DbContext
    {
        public SiafContext()
        {
        }

        public SiafContext(DbContextOptions<SiafContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<ClientTable> ClientTables { get; set; } = null!;
        public virtual DbSet<DepartementTable> DepartementTables { get; set; } = null!;
        public virtual DbSet<DevieTable> DevieTables { get; set; } = null!;
        public virtual DbSet<DeviseTable> DeviseTables { get; set; } = null!;
        public virtual DbSet<EtudeTable> EtudeTables { get; set; } = null!;
        public virtual DbSet<FabriquerTable> FabriquerTables { get; set; } = null!;
        public virtual DbSet<FournisseurTable> FournisseurTables { get; set; } = null!;
        public virtual DbSet<MachineTable> MachineTables { get; set; } = null!;
        public virtual DbSet<MargeTable> MargeTables { get; set; } = null!;
        public virtual DbSet<MatierePlatTable> MatierePlatTables { get; set; } = null!;
        public virtual DbSet<MatiereRondTable> MatiereRondTables { get; set; } = null!;
        public virtual DbSet<MatiereTable> MatiereTables { get; set; } = null!;
        public virtual DbSet<OperationTable> OperationTables { get; set; } = null!;
        public virtual DbSet<PersonnelTable> PersonnelTables { get; set; } = null!;
        public virtual DbSet<PieceSoutretTable> PieceSoutretTables { get; set; } = null!;
        public virtual DbSet<PieceTable> PieceTables { get; set; } = null!;
        public virtual DbSet<SoutraitantTable> SoutraitantTables { get; set; } = null!;
        public virtual DbSet<SoutretanceTable> SoutretanceTables { get; set; } = null!;
        public virtual DbSet<TypeFabTable> TypeFabTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=sms;Trusted_Connection=true;Trust Server Certificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<DevieTable>(entity =>
            {
                entity.HasKey(e => e.IdDev)
                    .HasName("PK_Table_1");

                entity.ToTable("DevieTable");

                entity.Property(e => e.IdDev)
                    .ValueGeneratedNever()
                    .HasColumnName("id_dev");

                entity.Property(e => e.DateCreation).HasColumnName("date_creation");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdDevise).HasColumnName("id_devise");

                entity.Property(e => e.IdUser)
                    .HasMaxLength(450)
                    .HasColumnName("id_user");

                entity.Property(e => e.NbHeurTt).HasColumnName("nb_heur_tt");

                entity.Property(e => e.NumDev).HasColumnName("num_dev");

                entity.Property(e => e.TotCout).HasColumnName("tot_cout");

                entity.Property(e => e.TotPrix).HasColumnName("tot_prix");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.DevieTables)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK_Table_1_clientTable");

                entity.HasOne(d => d.IdDeviseNavigation)
                    .WithMany(p => p.DevieTables)
                    .HasForeignKey(d => d.IdDevise)
                    .HasConstraintName("FK_DevieTable_DeviseTable");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DevieTables)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_DevieTable_AspNetUsers");
            });

            modelBuilder.Entity<DeviseTable>(entity =>
            {
                entity.HasKey(e => e.IdDevise);

                entity.ToTable("DeviseTable");

                entity.Property(e => e.IdDevise)
                    .ValueGeneratedNever()
                    .HasColumnName("id_devise");

                entity.Property(e => e.DateModif).HasColumnName("date_modif");

                entity.Property(e => e.Nom).HasColumnName("nom");

                entity.Property(e => e.Valeur).HasColumnName("valeur");
            });

            modelBuilder.Entity<EtudeTable>(entity =>
            {
                entity.HasIndex(e => e.IdClientNavigationId, "IX_EtudeTables_IdClientNavigationId");

                entity.HasIndex(e => e.IdPersoNavigationId, "IX_EtudeTables_IdPersoNavigationId");

                entity.HasIndex(e => e.PersonnelTableId, "IX_EtudeTables_PersonnelTableId");

                entity.Property(e => e.IdPersoNavigationId).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.EtudeTables)
                    .HasForeignKey(d => d.IdClientNavigationId);

                entity.HasOne(d => d.IdPersoNavigation)
                    .WithMany(p => p.EtudeTables)
                    .HasForeignKey(d => d.IdPersoNavigationId);

                entity.HasOne(d => d.PersonnelTable)
                    .WithMany(p => p.EtudeTables)
                    .HasForeignKey(d => d.PersonnelTableId);
            });

            modelBuilder.Entity<FabriquerTable>(entity =>
            {
                entity.HasKey(e => new { e.IdMachine, e.IdPiece });

                entity.ToTable("FabriquerTable");

                entity.Property(e => e.IdMachine).HasColumnName("id_machine");

                entity.Property(e => e.IdPiece).HasColumnName("id_piece");

                entity.Property(e => e.DateFabr).HasColumnName("date_fabr");

                entity.HasOne(d => d.IdMachineNavigation)
                    .WithMany(p => p.FabriquerTables)
                    .HasForeignKey(d => d.IdMachine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FabriquerTable_MachineTable");

                entity.HasOne(d => d.IdPieceNavigation)
                    .WithMany(p => p.FabriquerTables)
                    .HasForeignKey(d => d.IdPiece)
                    .HasConstraintName("FK_FabriquerTable_PieceTable");
            });

            modelBuilder.Entity<MachineTable>(entity =>
            {
                entity.HasKey(e => e.IdMachine);

                entity.ToTable("MachineTable");

                entity.Property(e => e.IdMachine)
                    .ValueGeneratedNever()
                    .HasColumnName("id_machine");

                entity.Property(e => e.IdFab).HasColumnName("id_fab");

                entity.Property(e => e.IpMachine)
                    .HasMaxLength(50)
                    .HasColumnName("ip_machine");

                entity.Property(e => e.NomMachine)
                    .IsUnicode(false)
                    .HasColumnName("nom_machine");

                entity.HasOne(d => d.IdFabNavigation)
                    .WithMany(p => p.MachineTables)
                    .HasForeignKey(d => d.IdFab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachineTable_TypeFabTable");
            });

            modelBuilder.Entity<MargeTable>(entity =>
            {
                entity.HasKey(e => e.IdMarge);

                entity.ToTable("MargeTable");

                entity.Property(e => e.IdMarge)
                    .ValueGeneratedNever()
                    .HasColumnName("id_marge");

                entity.Property(e => e.Marge).HasColumnName("marge");
            });

            modelBuilder.Entity<MatierePlatTable>(entity =>
            {
                entity.HasKey(e => e.IdMatiere);

                entity.ToTable("MatierePlatTable");

                entity.Property(e => e.IdMatiere)
                    .ValueGeneratedNever()
                    .HasColumnName("id_matiere");

                entity.Property(e => e.Houteur).HasColumnName("houteur");

                entity.Property(e => e.Largeur).HasColumnName("largeur");

                entity.Property(e => e.Longueur).HasColumnName("longueur");

                entity.HasOne(d => d.IdMatiereNavigation)
                    .WithOne(p => p.MatierePlatTable)
                    .HasForeignKey<MatierePlatTable>(d => d.IdMatiere)
                    .HasConstraintName("FK_MatierePlatTable_MatiereTable1");
            });

            modelBuilder.Entity<MatiereRondTable>(entity =>
            {
                entity.HasKey(e => e.IdMatiere);

                entity.ToTable("MatiereRondTable");

                entity.Property(e => e.IdMatiere)
                    .ValueGeneratedNever()
                    .HasColumnName("id_matiere");

                entity.Property(e => e.Diametre).HasColumnName("diametre");

                entity.Property(e => e.Longueur).HasColumnName("longueur");

                entity.HasOne(d => d.IdMatiereNavigation)
                    .WithOne(p => p.MatiereRondTable)
                    .HasForeignKey<MatiereRondTable>(d => d.IdMatiere)
                    .HasConstraintName("FK_MatiereRondTable_MatiereTable");
            });

            modelBuilder.Entity<MatiereTable>(entity =>
            {
                entity.HasKey(e => e.IdMatiere);

                entity.ToTable("MatiereTable");

                entity.Property(e => e.IdMatiere)
                    .ValueGeneratedNever()
                    .HasColumnName("id_matiere");

                entity.Property(e => e.DateAjout).HasColumnName("date_ajout");

                entity.Property(e => e.MassVolum).HasColumnName("mass_volum");

                entity.Property(e => e.NomMatiere)
                    .IsUnicode(false)
                    .HasColumnName("nom_matiere");

                entity.Property(e => e.PrixU).HasColumnName("prix_u");
            });

            modelBuilder.Entity<PersonnelTable>(entity =>
            {
                entity.HasIndex(e => e.DepartementId, "IX_PersonnelTables_DepartementId");

                entity.HasOne(d => d.Departement)
                    .WithMany(p => p.PersonnelTables)
                    .HasForeignKey(d => d.DepartementId);
            });

            modelBuilder.Entity<PieceSoutretTable>(entity =>
            {
                entity.HasKey(e => new { e.IdPiece, e.IdSout });

                entity.ToTable("PieceSoutretTable");

                entity.Property(e => e.IdPiece).HasColumnName("id_piece");

                entity.Property(e => e.IdSout).HasColumnName("id_sout");

                entity.Property(e => e.DateSout).HasColumnName("date_sout");

                entity.HasOne(d => d.IdPieceNavigation)
                    .WithMany(p => p.PieceSoutretTables)
                    .HasForeignKey(d => d.IdPiece)
                    .HasConstraintName("FK_PieceSoutretTable_PieceTable");

                entity.HasOne(d => d.IdSoutNavigation)
                    .WithMany(p => p.PieceSoutretTables)
                    .HasForeignKey(d => d.IdSout)
                    .HasConstraintName("FK_PieceSoutretTable_SoutretanceTable");
            });

            modelBuilder.Entity<PieceTable>(entity =>
            {
                entity.HasKey(e => e.IdPiece);

                entity.ToTable("PieceTable");

                entity.Property(e => e.IdPiece)
                    .ValueGeneratedNever()
                    .HasColumnName("id_piece");

                entity.Property(e => e.CoutMatier).HasColumnName("cout_matier");

                entity.Property(e => e.DesigPiece).HasColumnName("desig_piece");

                entity.Property(e => e.IdDevie).HasColumnName("id_devie");

                entity.Property(e => e.PrixRevient).HasColumnName("prix_revient");

                entity.Property(e => e.PrixTot).HasColumnName("prix_tot");

                entity.Property(e => e.PrixVenteU).HasColumnName("prix_vente_u");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.HasMany(d => d.IdMatieres)
                    .WithMany(p => p.IdPieces)
                    .UsingEntity<Dictionary<string, object>>(
                        "PieceMatiereTable",
                        l => l.HasOne<MatiereTable>().WithMany().HasForeignKey("IdMatiere").HasConstraintName("FK_PieceMatiereTable_MatiereTable"),
                        r => r.HasOne<PieceTable>().WithMany().HasForeignKey("IdPiece").HasConstraintName("FK_PieceMatiereTable_PieceTable"),
                        j =>
                        {
                            j.HasKey("IdPiece", "IdMatiere");

                            j.ToTable("PieceMatiereTable");

                            j.IndexerProperty<int>("IdPiece").HasColumnName("id_piece");

                            j.IndexerProperty<int>("IdMatiere").HasColumnName("id_matiere");
                        });
            });

            modelBuilder.Entity<SoutretanceTable>(entity =>
            {
                entity.HasKey(e => e.IdSout);

                entity.ToTable("SoutretanceTable");

                entity.Property(e => e.IdSout)
                    .ValueGeneratedNever()
                    .HasColumnName("id_sout");

                entity.Property(e => e.CoutSout).HasColumnName("cout_sout");

                entity.Property(e => e.DesigSout).HasColumnName("desig_sout");
            });

            modelBuilder.Entity<TypeFabTable>(entity =>
            {
                entity.HasKey(e => e.IdFab);

                entity.ToTable("TypeFabTable");

                entity.Property(e => e.IdFab)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fab");

                entity.Property(e => e.TypeFab).HasColumnName("type_fab");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
