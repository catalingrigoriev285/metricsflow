using metricsflow.Data;
using metricsflow.Models;

User user = new User
{
    username = "admin2",
    password = "admin2",
    email = "admin2@gmail.com",
    role = "admin"
};

using (var context = new DatabaseContext())
{
    context.Users.Add(user);
    context.SaveChanges();
}

Console.WriteLine("User added successfully");