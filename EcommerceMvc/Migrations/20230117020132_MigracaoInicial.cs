using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceMvc.Migrations;

/// <inheritdoc />
public partial class MigracaoInicial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterDatabase()
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Categorias",
            columns: table => new
            {
                CategoriaId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                CategoriaNome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Descricao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4")
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateTable(
            name: "Produtos",
            columns: table => new
            {
                ProdutoId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                DescricaoCurta = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                DescricaoDetalhada = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                ImagemUrl = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                ImagemThumbnailUrl = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                    .Annotation("MySql:CharSet", "utf8mb4"),
                IsProdutoPreferido = table.Column<bool>(type: "tinyint(1)", nullable: false),
                EmEstoque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                CategoriaId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                table.ForeignKey(
                    name: "FK_Produtos_Categorias_CategoriaId",
                    column: x => x.CategoriaId,
                    principalTable: "Categorias",
                    principalColumn: "CategoriaId",
                    onDelete: ReferentialAction.Cascade);
            })
            .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateIndex(
            name: "IX_Produtos_CategoriaId",
            table: "Produtos",
            column: "CategoriaId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Produtos");

        migrationBuilder.DropTable(
            name: "Categorias");
    }
}
