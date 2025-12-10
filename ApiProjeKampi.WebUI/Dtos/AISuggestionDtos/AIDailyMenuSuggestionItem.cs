namespace ApiProjeKampi.WebUI.Dtos.AISuggestionDtos
{
    public class AIDailyMenuSuggestionItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Reason { get; set; }
    }
}
