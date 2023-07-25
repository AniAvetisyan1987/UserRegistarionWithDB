using UserRegistarionWithDB.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        AddUser(1, "Anna", "AnnaAvetyan", "123456");
        AddUser(2, "Artur", "ArturAvetyan", "123456");
        AddUser(3, "Armine", "ArmineAvetyan", "123456");
        AddUser(4, "Anna", "AnnaAvetyan", "234167");
    }

    static void AddUser(int id, string name, string login, string pass)
    {
        var context = new UsersContext();
        var user = new User { Id = id, Username = name, Login = login, Password = pass };
        context.Add(user);
        context.SaveChanges();
    }
}