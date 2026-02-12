namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast bilmærke: ");
            string brand = Console.ReadLine();
            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();
            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast geartype (A for automatisk, M for manuel: ");
            char gearType = Console.ReadLine()[0];
            Console.WriteLine("Bilmærke: " + brand);
            Console.WriteLine("Bilmodel: " + model);
            Console.WriteLine("Årgang: " + year);
            Console.WriteLine("Gear: " + gearType);
            Console.WriteLine($"\n{brand} {model} fra {year} har gear {gearType}.");
            Console.WriteLine(brand + " " + model + " fra " + year + " har gear: " + gearType);
        }
    }
}
