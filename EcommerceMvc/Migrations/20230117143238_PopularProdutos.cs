using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceMvc.Migrations;

/// <inheritdoc />
public partial class PopularProdutos : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) VALUES(1, 'Camisa social Calvin Klein', 'Camisa social Calvin klein, Cor rosa, Produto 100% algodão', 1, 'https://kimarca.com/wp-content/uploads/2019/05/Social-Calvin-Klein-Rosa.jpg', 'https://kimarca.com/wp-content/uploads/2019/05/Social-Calvin-Klein-Rosa.jpg', 0, 'Social Calvin Klein', 349.99 )");

        migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) VALUES(1, 'Camisa Polo Calvin Klein', 'Polo Calvin klein, Cor Branca com detalhes azul, Produto 100% algodão', 1, 'https://photos.enjoei.com.br/camisa-polo-calvin-klein-original-branca/1200xN/czM6Ly9waG90b3MuZW5qb2VpLmNvbS5ici9wcm9kdWN0cy8xMTM5ODMyOS8yZTY5NWY2ODE5Yzc5NjYxY2EyNGUxZGQ0NDhmNDQyZS5qcGc', 'https://photos.enjoei.com.br/camisa-polo-calvin-klein-original-branca/1200xN/czM6Ly9waG90b3MuZW5qb2VpLmNvbS5ici9wcm9kdWN0cy8xMTM5ODMyOS8yZTY5NWY2ODE5Yzc5NjYxY2EyNGUxZGQ0NDhmNDQyZS5qcGc', 0, 'Polo Calvin Klein', 239.99 )");

        migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsProdutoPreferido,Nome,Preco) VALUES(1, 'Camiseta estilo T-Shirt Calvin Klein', 'T-Shirt Calvin klein, Cor Preta, Produto 100% algodão', 1, 'https://photos6.spartoo.pt/photos/177/17787739/17787739_1200_A.jpg', 'https://photos6.spartoo.pt/photos/177/17787739/17787739_1200_A.jpg', 1, 'Camiseta Calvin Klein', 189.99 )");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM Produtos");
    }
}
