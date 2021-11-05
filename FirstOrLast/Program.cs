using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanimi.
            //programm kontrollib andmete pikkust
            //progremm kuvab kumb on nendest pikem, kas ees- või perekonnanimi. <>

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;

            if(firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Teie eesnimi on pikem kui perekonnanimi");
            }
            else if(firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Teie perekonnanimi on pikem kui eesnimi");
            }
            else
            {
                Console.WriteLine("Teie eesnimi ja perekonnanimi on sama pikad");
            }
        }
    }
}
