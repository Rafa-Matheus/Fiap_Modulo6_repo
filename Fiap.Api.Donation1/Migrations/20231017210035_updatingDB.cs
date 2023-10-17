using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fiap.Api.Donation1.Migrations
{
    /// <inheritdoc />
    public partial class updatingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "DataCadastro", "DataExpiracao", "Descricao", "Disponivel", "Nome", "SugestaoTroca", "TipoProdutoId", "UsuarioId", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3874), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3875), "Descrição", true, "Produto 1", "Sugestão de troca", 1, 1, 1.0 },
                    { 2, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3881), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3882), "Descrição", true, "Produto 2", "Sugestão de troca", 1, 1, 1.0 },
                    { 3, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3883), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3883), "Descrição", true, "Produto 3", "Sugestão de troca", 1, 1, 1.0 },
                    { 4, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3884), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3885), "Descrição", true, "Produto 4", "Sugestão de troca", 1, 1, 1.0 },
                    { 5, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3886), "Descrição", true, "Produto 5", "Sugestão de troca", 1, 1, 1.0 },
                    { 6, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3887), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3888), "Descrição", true, "Produto 6", "Sugestão de troca", 1, 1, 1.0 },
                    { 7, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3889), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3889), "Descrição", true, "Produto 7", "Sugestão de troca", 1, 1, 1.0 },
                    { 8, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3890), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3891), "Descrição", true, "Produto 8", "Sugestão de troca", 1, 1, 1.0 },
                    { 9, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3892), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3892), "Descrição", true, "Produto 9", "Sugestão de troca", 1, 1, 1.0 },
                    { 10, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3893), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3894), "Descrição", true, "Produto 10", "Sugestão de troca", 1, 1, 1.0 },
                    { 11, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3899), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3899), "Descrição", true, "Produto 11", "Sugestão de troca", 1, 1, 1.0 },
                    { 12, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3900), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3900), "Descrição", true, "Produto 12", "Sugestão de troca", 1, 1, 1.0 },
                    { 13, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3902), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3902), "Descrição", true, "Produto 13", "Sugestão de troca", 1, 1, 1.0 },
                    { 14, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3903), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3903), "Descrição", true, "Produto 14", "Sugestão de troca", 1, 1, 1.0 },
                    { 15, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3904), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3905), "Descrição", true, "Produto 15", "Sugestão de troca", 1, 1, 1.0 },
                    { 16, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3906), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3906), "Descrição", true, "Produto 16", "Sugestão de troca", 1, 1, 1.0 },
                    { 17, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3908), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3908), "Descrição", true, "Produto 17", "Sugestão de troca", 1, 1, 1.0 },
                    { 18, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3909), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3909), "Descrição", true, "Produto 18", "Sugestão de troca", 1, 1, 1.0 },
                    { 19, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3910), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3911), "Descrição", true, "Produto 19", "Sugestão de troca", 1, 1, 1.0 },
                    { 20, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3912), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3912), "Descrição", true, "Produto 20", "Sugestão de troca", 1, 1, 1.0 },
                    { 21, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3914), "Descrição", true, "Produto 21", "Sugestão de troca", 1, 1, 1.0 },
                    { 22, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3915), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3915), "Descrição", true, "Produto 22", "Sugestão de troca", 1, 1, 1.0 },
                    { 23, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3916), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3917), "Descrição", true, "Produto 23", "Sugestão de troca", 1, 1, 1.0 },
                    { 24, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3918), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3918), "Descrição", true, "Produto 24", "Sugestão de troca", 1, 1, 1.0 },
                    { 25, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3919), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3920), "Descrição", true, "Produto 25", "Sugestão de troca", 1, 1, 1.0 },
                    { 26, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3921), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3921), "Descrição", true, "Produto 26", "Sugestão de troca", 1, 1, 1.0 },
                    { 27, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3922), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3923), "Descrição", true, "Produto 27", "Sugestão de troca", 1, 1, 1.0 },
                    { 28, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3924), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3924), "Descrição", true, "Produto 28", "Sugestão de troca", 1, 1, 1.0 },
                    { 29, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3925), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3926), "Descrição", true, "Produto 29", "Sugestão de troca", 1, 1, 1.0 },
                    { 30, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3927), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3927), "Descrição", true, "Produto 30", "Sugestão de troca", 1, 1, 1.0 },
                    { 31, new DateTime(2023, 10, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 4, 17, 18, 0, 34, 466, DateTimeKind.Local).AddTicks(3934), "Descrição", true, "Produto 31", "Sugestão de troca", 1, 1, 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto",
                column: "DataCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Produto_DataCadastro",
                table: "Produto");

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31);
        }
    }
}
