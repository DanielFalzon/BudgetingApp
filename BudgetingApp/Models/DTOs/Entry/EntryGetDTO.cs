using BudgetingApp.Models.DTOs.Category;

namespace BudgetingApp.Models.DTOs.Entry
{
    public record struct EntryGetDTO
    {
        public  string Description { get; set; }
        public decimal Amount { get; set; }
        public CategoryGetDTO Category { get; set; }
        public EntryType EntryType { get; set; }
        public DateOnly SubmittedOn { get; set; }
    }
}
