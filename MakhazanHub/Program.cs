using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StorDatabase_3_1.ApplicationDbcontexet;
using StorDatabase_3_1.Model;

namespace StorDatabase_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDBstore())
            {
                // Sample usage: Retrieve and display all users from the database
                var users = context.Users.ToList();

                Console.WriteLine("List of Users:");
                foreach (var user in users)
                {
                    Console.WriteLine($"UserID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");
                }
            }
        }
    }
}