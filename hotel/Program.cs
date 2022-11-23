using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Person> hospedes = new List<Person>();

Person p1 = new Person(name: "Hóspede 1");
Person p2 = new Person(name: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(typeSuite: "Premium", capacity: 5, dailyValue: 10);

Reserve reserve = new Reserve(reservedDays: 10);
reserve.registerSuite(suite);
reserve.registerGuests(hospedes);


if (reserve.getAmountGuests() > 0)
{
    Console.WriteLine($"Hóspedes: {reserve.getAmountGuests()}");
    Console.WriteLine($"Valor diária: {reserve.CalculateTotalValue()}");

}