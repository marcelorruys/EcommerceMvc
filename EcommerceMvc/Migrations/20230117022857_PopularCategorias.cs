using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceMvc.Migrations;

/// <inheritdoc />
public partial class PopularCategorias : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Camisa', 'Esta peça propõe um traje social, feita de tecidos mais nobres.')");

        migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Camisa Polo', 'Esta peça é a mistura de um traje social e casual, ideal para confraternizações.')");

        migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('Camiseta', 'Esta peça proporciona uma impressão casual, ideal para o dia a dia.')");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE DROM Categorias");
    }
}
