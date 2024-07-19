using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }

        public abstract void Subscribe(Student std);
    }
}
