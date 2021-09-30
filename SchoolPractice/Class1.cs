using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        private string name { get; set; }
        private int courseId { get; set; }
        private Dictionary<string, int> requirements = new Dictionary<string, int>();
            requirements.Add("javaScript" : 101);
            requirements.Add("methods" : 102);
            requirements.Add("dry coding" : 103);
        
    }
}
