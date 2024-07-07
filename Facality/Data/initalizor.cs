using System;
using Facality.Models;
using Microsoft.EntityFrameworkCore;

namespace Facality.Data
{
    public class initalizor
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var contxt = ServiceScope.ServiceProvider.GetService<AppDbcontext>();
                contxt.Database.EnsureCreated();

                if (!contxt.students.Any())
                {
                    contxt.students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            StudentName="Ezz eldeen",
                            gender="male",
                            Studentphone=01145635545,
                            Birthday= new (2007,8,24),
                        } ,
                        new Student()
                        {
                            StudentName="Mezo",
                            gender="Female",
                            Studentphone=01025464553,
                            Birthday= new (2001,2,5),
                        }
                    });
                    contxt.SaveChanges();     
                }

                if (!contxt.faccalities.Any())
                {
                    contxt.faccalities.AddRange(new List<faccality>()

                    {
                        new faccality()
                        {
                            FacalityName="USA",
                            Facalityphone=01213456332,
                            Facalityaddress="Amirica"
                        }

                    });
                    contxt.SaveChanges();
                }

            }
        }
    }
}
