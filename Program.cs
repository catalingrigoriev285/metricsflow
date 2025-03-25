using metricsflow.app.Data;
using metricsflow.app.Models;

User user = new User
{
    username = "admin",
    password = "admin",
    email = "admin@gmail.com",
    role = "admin"
};

using (var context = new DatabaseContext())
{
    context.Users.Add(user);
    context.SaveChanges();
}

Console.WriteLine("User added successfully");