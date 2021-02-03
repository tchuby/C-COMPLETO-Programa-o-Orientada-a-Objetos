using System;
using System.Globalization;

namespace RentRooms
{
    public class Service
    {
        public static void Interact()
        {
            var rooms = CreateVect();

            Console.Write("How many rooms will be rented? ");
            int quantity = int.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            var updatedRooms = DataInput(rooms, quantity);
            
            Show(updatedRooms);
        }

        private static Room[] CreateVect()
        {
            int quantityRooms = 10;
            Room[] rooms = new Room[quantityRooms];

            for(int i =1; i <= quantityRooms; i++)
            {
                var room = Room.Create(i);
                rooms[i-1] = room;
            }

            return rooms;
        }

        private static Room[] DataInput(Room[] rooms, int quantity)
        {
            for(int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Email: ");
                var email = Console.ReadLine();
                Console.Write("Room: ");
                var number = int.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);
                Console.WriteLine();

                Room.Update(rooms[number-1], number, name, email);
            }

            return rooms;
        }

        private static void Show(Room[] rooms)
        {
            foreach( var room in rooms)
            { 
                if(room._rented)
                {
                    Console.WriteLine(room);
                }
            }

        }
    }
}
