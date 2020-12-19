using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeFormsMVC.Models;

namespace FreeFormsMVC
{
    public class SampleData
    {
        public static void Initialize(PersonContext context)
        {
            if
                (!context.Persons.Any())
            {
                context.Persons.AddRange
                    (
                    new Person
                    {
                        Name = "Иван",
                        Surname = "Иванов",
                        Patronymic = "Иванович",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
