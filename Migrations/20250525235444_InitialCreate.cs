using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeMottu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "net_Filial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeFilial = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    CodCidade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TamanhoPatio = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_net_Filial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "net_Moto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Modelo = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    AnoFabricacao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Placa = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    Categoria = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_net_Moto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "net_Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    TipoAcesso = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    FuncaoUsuario = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    IdFilial = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_net_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_net_Funcionario_net_Filial_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "net_Filial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_net_Funcionario_IdFilial",
                table: "net_Funcionario",
                column: "IdFilial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "net_Funcionario");

            migrationBuilder.DropTable(
                name: "net_Moto");

            migrationBuilder.DropTable(
                name: "net_Filial");
        }
    }
}
