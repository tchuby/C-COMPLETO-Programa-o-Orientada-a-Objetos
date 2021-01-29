namespace RentRooms
{
    public class Tenant
    {
        public string Name { get;  protected set; }
        public string Email { get; set; }

        public Tenant(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public static Tenant Create(string name, string email)
        {
            Tenant tenant = new Tenant(name, email)
            {
                Name = name,
                Email = email
            };

            return tenant;
        }
    }
}
