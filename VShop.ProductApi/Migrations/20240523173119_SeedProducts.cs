using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name, Price, Description, Stock, ImageURL, CategoryId) Values" +
                "('Caderno', 7.50, 'Caderno brochura', 10, 'caderno1.jpg', 1)");
            mb.Sql("INSERT INTO Products(Name, Price, Description, Stock, ImageURL, CategoryId) Values" +
                "('Lápis', 4.50, 'Lápis 2b', 50, 'lapis1.jpg', 1)");
            mb.Sql("INSERT INTO Products(Name, Price, Description, Stock, ImageURL, CategoryId) Values" +
                "('Clips', 2.50, 'Clips coloridos', 60, 'clips1.jpg', 2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
