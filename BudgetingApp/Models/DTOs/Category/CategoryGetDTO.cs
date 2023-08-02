namespace BudgetingApp.Models.DTOs.Category
{
    public record struct CategoryGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
