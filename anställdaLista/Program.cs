List<Anstalld> anstallda = new List<Anstalld>();
Console.WriteLine("skriv antal anställda på restaurang"); 
var antalanstallda = int.Parse(Console.ReadLine());
for (int i = 0; i < antalanstallda; i++)
{
    Console.WriteLine($"Skriv information for personal {i + 1}");
    Console.Write("Namn: ");
    var name = Console.ReadLine();
    Console.WriteLine("Lön: ");
    var lon = decimal.Parse(Console.ReadLine());
    anstallda.Add(new Anstalld { Namn = name, Lon = lon });
}
Console.WriteLine("anställda Lista");
foreach (var anstalld in anstallda)
{
    Console.WriteLine($"Namn: {anstalld.Namn}, Lön: {anstalld.Lon}");
}


internal class Anstalld
{
    public string ?Namn { get; set; }
    public decimal Lon { get; set; }
}