namespace Hospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string typeSuite,
                     int capacity,
                     decimal dailyValue)
        {
            this.typeSuite = typeSuite;
            this.capacity = capacity;
            this.dailyValue = dailyValue;
        }

        public string? typeSuite { get; set; }
        public int? capacity { get; set; }
        public decimal? dailyValue { get; set; }
    }
}