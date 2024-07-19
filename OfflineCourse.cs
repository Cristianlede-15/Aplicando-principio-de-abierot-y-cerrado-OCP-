using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Estudiante " + std.Name + " en el curso offline");
        }
    }
    
    }

