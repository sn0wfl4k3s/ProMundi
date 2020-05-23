using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(maxLength: 255, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    UrlFoto = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(maxLength: 255, nullable: false),
                    SeProfissional = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaUsuarios",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaUsuarios", x => new { x.CategoriaId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_CategoriaUsuarios_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    Nota = table.Column<int>(nullable: false),
                    VideoPath = table.Column<string>(nullable: true),
                    PodcastPath = table.Column<string>(nullable: true),
                    UrlImgPost = table.Column<string>(nullable: true),
                    Favorito = table.Column<bool>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataEdicao = table.Column<DateTime>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conteudos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Conteudos_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConteudoCategorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false),
                    ConteudoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudoCategorias", x => new { x.CategoriaId, x.ConteudoId });
                    table.ForeignKey(
                        name: "FK_ConteudoCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConteudoCategorias_Conteudos_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConteudoTemas",
                columns: table => new
                {
                    ConteudoId = table.Column<int>(nullable: false),
                    TemaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudoTemas", x => new { x.TemaId, x.ConteudoId });
                    table.ForeignKey(
                        name: "FK_ConteudoTemas_Conteudos_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConteudoTemas_Temas_TemaId",
                        column: x => x.TemaId,
                        principalTable: "Temas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaUsuarios_UsuarioId",
                table: "CategoriaUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_ConteudoId",
                table: "Comentarios",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoCategorias_ConteudoId",
                table: "ConteudoCategorias",
                column: "ConteudoId");

            migrationBuilder.CreateIndex(
                name: "IX_Conteudos_UsuarioId",
                table: "Conteudos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoTemas_ConteudoId",
                table: "ConteudoTemas",
                column: "ConteudoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaUsuarios");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "ConteudoCategorias");

            migrationBuilder.DropTable(
                name: "ConteudoTemas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Conteudos");

            migrationBuilder.DropTable(
                name: "Temas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
