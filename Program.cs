using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Course course = new OnlineCourse();
            course.Subscribe(new Student { Name = "Cristian" });

            course = new OfflineCourse();
            course.Subscribe(new Student { Name = "Alberto" });
        }
    }
}
