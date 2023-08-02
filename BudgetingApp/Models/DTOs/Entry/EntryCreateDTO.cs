namespace BudgetingApp.Models.DTOs.Entry
{
    public record struct EntryCreateDTO
    {
        public required string Description { get; set; }
        public required decimal Amount { get; set; }
        public required int CategoryId { get; set; }
        public required EntryType EntryType { get; set; }
        public required DateOnly SubmittedOn { get; set; }
    }
}
