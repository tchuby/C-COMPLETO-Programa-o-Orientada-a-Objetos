using System;
using System.Globalization;

namespace RentRooms
{
    public class Service
    {
        public static void Interact()
        {
            Console.Write("How many rooms will be rented? ");
            int quantity = int.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            var rooms = CreateVect(quantity);
            DataInput(quantity);
            var rentedRooms = Room.GetRooms(rooms);
            Show(rentedRooms);
        }

        private static Room[] CreateVect(int quantity)
        {
            Room[] rooms = new Room[quantity];

            for(int i =0; i < quantity; i++)
            {
                var room = Room.Create(i);
            }

            return rooms;
        }

        private static 

        private void Show(Room[] rooms)
        {
            Console.WriteLine(rentedRooms);
        }
    }
}
