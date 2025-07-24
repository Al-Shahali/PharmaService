using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaDataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterYear = table.Column<int>(type: "int", nullable: false),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtcCode1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtcCode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageSize = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShelfLife = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdministrationRoute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoesageForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorageConditions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductControl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductControlAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalManufacturerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalStatusEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalStatusAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributionArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyCountryEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyCountryAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugCombinations_StrengthValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugCombinations_ScientificName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugCombinations_StrengthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");
        }
    }
}
