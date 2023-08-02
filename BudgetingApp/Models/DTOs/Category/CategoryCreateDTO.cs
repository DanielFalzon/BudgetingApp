namespace BudgetingApp.Models.DTOs.Category
{
    public record struct CategoryCreateDTO
    {
        public required string Name { get; set; }
    }
}
