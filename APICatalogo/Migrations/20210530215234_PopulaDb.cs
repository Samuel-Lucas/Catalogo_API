﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Bebidas'," +
                "'http://www.macoratti.net/Imagens/1.jpg')");
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Lanches'," +
                "'http://www.macoratti.net/Imagens/2.jpg')");
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Sobremesas'," +
                "'http://www.macoratti.net/Imagens/3.jpg')");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Coca-Cola Diet', 'Refrigerante 350ml', 5.45, 'http://www.macoratti.net/Imagens/coca.jpg', 50,now(), (Select CategoriaId from Categorias where Nome = 'Bebidas'))");
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Lanche de atum', 'Atum com queijo', 8.50, 'http://www.macoratti.net/Imagens/atum.jpg', 10,now(), (Select CategoriaId from Categorias where Nome = 'Lanches'))");
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Pudim', 'Pudim de leite condensado', 6.75, 'http://www.macoratti.net/Imagens/pudim.jpg', 20,now(), (Select CategoriaId from Categorias where Nome = 'Sobremesas'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}