namespace BudgetingApp.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public EntryType EntryType { get; set; }
        public DateOnly SubmittedOn { get; set; }
    }
}
