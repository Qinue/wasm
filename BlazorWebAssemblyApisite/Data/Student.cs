using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApisite.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Class { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }
    }
}
