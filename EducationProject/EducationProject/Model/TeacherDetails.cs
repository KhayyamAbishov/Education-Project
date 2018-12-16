using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject.Model
{
    class TeacherDetails:DbContext
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherPhoto { get; set; }
        public string TeacherBio { get; set; }
        public string TeacherSpeciality { get; set; }
        
    }
}
