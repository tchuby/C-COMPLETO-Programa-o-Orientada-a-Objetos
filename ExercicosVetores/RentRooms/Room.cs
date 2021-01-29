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

        }

        public static Room Create(int number)
        {
            Room room = new Room(number)
            {
                Number = number
            };

            return room;
        }

        public static Room Update(int number, string name, string email)
        {
            var tenant = Tenant.Create(name, email);
            

        }
    }
}
