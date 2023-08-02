namespace BudgetingApp.Models.DTOs.SaveTarget
{
    public record struct SaveTargetCreateDTO
    {
        public required decimal Amount { get; set; }
        public required DateOnly DateFrom { get; set; }
        public required DateTime DateTo { get; set; }
    }
}
