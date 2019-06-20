using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwic10.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new cwic10Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<cwic10Context>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        FirstName = "Alex",
                        LastName = "Konor",
                        NrIndeksu ="s17324"
                        
                    },

                    new Student
                    {

                        FirstName = "Volodia",
                        LastName = "Lox",
                        NrIndeksu = "s17338"
                    },

                    new Student
                    {

                        FirstName = "Bigli",
                        LastName = "Bugli",
                        NrIndeksu = "s00007"
                    },

                    new Student
                    {

                        FirstName = "Drug",
                        LastName = "Anton",
                        NrIndeksu = "s13337"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}

