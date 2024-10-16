using Tast_1;

namespace Task3OverlisingandOperterOverLooding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(1, 10, 15);
            if (D1.Equals(D2)) {
                Console.WriteLine("Two Duration are equald");
            }
            else
                Console.WriteLine("Two Duration are equald");
            Duration D3 = D1 + D2;
            Console.WriteLine($"D1+D2 = {D3}");
            Duration D4 = 999 + D2;
            Console.WriteLine($"Second+D2 = {D4}");
            Duration D5 =  D2++;
            Console.WriteLine($"D2++ = {D5}");
            Duration D6 =  D2--;
            Console.WriteLine($"D2-- = {D6}");
            if(D1 <= D2){
                Console.WriteLine("D1 <= D2");
            }else
                Console.WriteLine("D1 >= D2");






        }
    }
}
