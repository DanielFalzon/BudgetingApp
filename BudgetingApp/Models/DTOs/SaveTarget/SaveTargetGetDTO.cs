namespace BudgetingApp.Models.DTOs.SaveTarget
{
    public record struct SaveTargetGetDTO
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
