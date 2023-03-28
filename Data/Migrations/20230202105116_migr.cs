using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiafManagementStudio.Data.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartementTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Depatement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartementTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviseTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviseTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FournisseurTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FournisseurTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutHorraire = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatiereTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    DateModif = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatiereTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoutraitantTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoutraitantTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cp = table.Column<int>(type: "int", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatriculeCnss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricule = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cin = table.Column<int>(type: "int", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LieuNaissance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonnelTables_DepartementTables_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "DepartementTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtudeTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    NumFicheTechnique = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomDeProjet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbrFt = table.Column<int>(type: "int", nullable: false),
                    DateDeb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFinPrev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLivraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdClientNavigationId = table.Column<int>(type: "int", nullable: false),
                    IdPersoNavigationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonnelTableId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtudeTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtudeTables_AspNetUsers_IdPersoNavigationId",
                        column: x => x.IdPersoNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EtudeTables_ClientTables_IdClientNavigationId",
                        column: x => x.IdClientNavigationId,
                        principalTable: "ClientTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtudeTables_PersonnelTables_PersonnelTableId",
                        column: x => x.PersonnelTableId,
                        principalTable: "PersonnelTables",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EtudeTables_IdClientNavigationId",
                table: "EtudeTables",
                column: "IdClientNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_EtudeTables_IdPersoNavigationId",
                table: "EtudeTables",
                column: "IdPersoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_EtudeTables_PersonnelTableId",
                table: "EtudeTables",
                column: "PersonnelTableId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelTables_DepartementId",
                table: "PersonnelTables",
                column: "DepartementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviseTables");

            migrationBuilder.DropTable(
                name: "EtudeTables");

            migrationBuilder.DropTable(
                name: "FournisseurTables");

            migrationBuilder.DropTable(
                name: "MachineTables");

            migrationBuilder.DropTable(
                name: "MatiereTables");

            migrationBuilder.DropTable(
                name: "OperationTables");

            migrationBuilder.DropTable(
                name: "SoutraitantTables");

            migrationBuilder.DropTable(
                name: "ClientTables");

            migrationBuilder.DropTable(
                name: "PersonnelTables");

            migrationBuilder.DropTable(
                name: "DepartementTables");
        }
    }
}
