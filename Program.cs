using System;

namespace exPensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int hospedes = int.Parse(Console.ReadLine());

            Hospedes[] vect = new Hospedes[10];

            for(int i = 0; i < hospedes; i++)
            {
                int numRoom = i + 1;
                Console.WriteLine("Rent #" + numRoom);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string e_mail = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();
                vect[room] = new Hospedes { Name = name, E_mail = e_mail, Room = room };
            }

            Console.WriteLine("Busy Rooms: ");

            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].Room + " :" + vect[i].Name + " ," +  vect[i].E_mail);
                }
            }
        }
    }
}
