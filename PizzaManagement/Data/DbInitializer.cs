using PizzaManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "David", LastName = "Hume", PhoneNumber = "123-123-1234", Role = Roles.Manager, Salary = 100000M},
                new Employee{FirstName = "Timmy", LastName = "Johnson", PhoneNumber = "123-123-1234", Role = Roles.AssistantManager, Salary = 16000M},
                new Employee{FirstName = "Jimmy", LastName = "Smith", PhoneNumber = "123-123-1234", Role = Roles.Cashier, Salary = 10000M}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
