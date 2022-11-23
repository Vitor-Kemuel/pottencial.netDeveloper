namespace Hospedagem.Models
{
    public class Reserve
    {
        public List<Person>? guests { get; set; }
        public Suite? suite { get; set; }
        public int? reservedDays { get; set; }

        public Reserve() { }

        public Reserve(int reservedDays)
        {
            this.reservedDays = reservedDays;
        }

        public void registerGuests(List<Person> guests)
        {
            if (suite!.capacity >= guests.Count)
            {
                this.guests = guests;
            }
            else
            {
                Console.WriteLine("Capacidade da suite é insuficiente!");
            }
        }

        public void registerSuite(Suite suite)
        {
            this.suite = suite;
        }

        public int getAmountGuests()
        {
            return guests != null ? guests.Count : 0;
        }

        public decimal CalculateTotalValue()
        {
            decimal value = 0;
            value = (decimal)(reservedDays! * suite!.dailyValue!);

            if (reservedDays >= 10)
            {
                value = value - value * 0.10M;
            }

            return value;
        }
    }
}