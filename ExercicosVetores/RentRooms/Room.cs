namespace RentRooms
{
    public class Room
    {
        private bool _rented = false;

        public int Number { get; set; }
        public Tenant Tenant { get; set; }

        public Room(int number)
        {
            Number = number;
        }

        public Room(int number, Tenant tenant)
        {
            Number = number;
            Tenant = tenant;
        }

        public static Room Create(int number)
        {
            Room room = new Room(number)
            {
                Number = number
            };

            return room;
        }

        public static Room Update(Room room, int number, string name, string email)
        {
            var tenant = Tenant.Create(name, email);

            room.Number = number;
            room.Tenant = tenant;
            room._rented = true;

            return room;
        }

        public static Room[] GetRooms(Room[] rooms)
        {
            return rooms;
        }

        public override string ToString()
        {
            var write = Number + ": " + Tenant.Name + ", " + Tenant.Email;
            return write;
        }
    }
}
