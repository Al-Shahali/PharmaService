using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDataBase
{
    public class Drug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string? RegisterNumber { get; set; }
        public int? RegisterYear { get; set; }
        public string? TradeName { get; set; }
        public string? ScientificName { get; set; }
        public string? AtcCode1 { get; set; }
        public string? AtcCode2 { get; set; }

        public int? PackageSize { get; set; }
        public int? Size { get; set; }
        public string? Strength { get; set; }
        public int? ShelfLife { get; set; }

        public string? Price { get; set; }
        public string? DrugType { get; set; }
        public string? PackageType { get; set; }
        public string? SizeUnit { get; set; }
        public string? StrengthUnit { get; set; }
        public string? AdministrationRoute { get; set; }
        public string? DoesageForm { get; set; }
        public string? StorageConditions { get; set; }
        public string? MarketingStatus { get; set; }
        public string? LegalStatus { get; set; }
        public string? ProductControl { get; set; }
        public string? ProductControlAr { get; set; }
        public string? AuthorizationStatus { get; set; }
        public string? Agent { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ManufacturerCountry { get; set; }
        public string? AdditionalManufacturer { get; set; }
        public string? AdditionalManufacturerCountry { get; set; }
        public string? CompanyName { get; set; }
        public string? LegalStatusEn { get; set; }
        public string? LegalStatusAr { get; set; }
        public string? DomainEN { get; set; }
        public string? DomainAR { get; set; }
        public string? ImageUrl { get; set; }
        public string? DistributionArea { get; set; }
        public string? CompanyCountryEn { get; set; }
        public string? CompanyCountryAr { get; set; }
        public string? DrugCombinations_StrengthValue { get; set; }
        public string? DrugCombinations_ScientificName { get; set; }
        public string? DrugCombinations_StrengthUnit { get; set; }
        public string? DescriptionCode { get; set; }
    }

    public class DrugResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

        [NotMapped]
        public List<Drug> Results { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int FirstRowOnPage { get; set; }
        public int LastRowOnPage { get; set; }
    }

}
