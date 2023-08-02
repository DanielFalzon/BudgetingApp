namespace BudgetingApp.Models
{
    public class SaveTarget
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
